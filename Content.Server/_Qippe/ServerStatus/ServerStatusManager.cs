using System.Net;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Content.Shared._Qippe.QVars;
using Robust.Server.ServerStatus;
using Robust.Shared.Configuration;
using Robust.Shared.Player;

namespace Content.Server._Qippe.ServerStatus;

public sealed partial class ServerStatusManager : IPostInjectInit
{
    [Dependency] private IStatusHost _statusHost = default!;
    [Dependency] private ISharedPlayerManager _sharedPlayerManager = default!;
    [Dependency] private IConfigurationManager _cfg = default!;

    void IPostInjectInit.PostInject()
    {
    }

    public void Initialize()
    {
        _statusHost.AddHandler(HandlePlayerList);
    }

    private async Task<bool> HandlePlayerList(IStatusHandlerContext statusHandlerContext)
    {
        if (!statusHandlerContext.IsGetLike || statusHandlerContext.Url.AbsolutePath != "/playerlist")
        {
            return false;
        }

        var enabled = _cfg.GetCVar(QVars.StatusPlayerList);
        if (!enabled)
        {
            await statusHandlerContext.RespondErrorAsync(HttpStatusCode.Forbidden);
            return false;
        }

        var playerCount = _sharedPlayerManager.PlayerCount;
        var playerList = new JsonArray();
        var jObject = new JsonObject();

        foreach (var player in _sharedPlayerManager.Sessions)
        {
            playerList.Add(player.Name);
        }

        jObject["playerCount"] = playerCount;
        jObject["players"] = playerList;

        await statusHandlerContext.RespondJsonAsync(jObject);
        return true;
    }
}
