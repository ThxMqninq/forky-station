using System.Net;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Content.Server.Database;
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
    [Dependency] private IServerDbManager _db = default!;

    void IPostInjectInit.PostInject()
    {
    }

    public void Initialize()
    {
        _statusHost.AddHandler(HandlePlayerList);
        _statusHost.AddHandler(HandlePlayerRecord);
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

    private async Task<bool> HandlePlayerRecord(IStatusHandlerContext statusHandlerContext)
    {
        if (!statusHandlerContext.IsGetLike || statusHandlerContext.Url.AbsolutePath != "/player")
            return false;

        var nameString = statusHandlerContext.Url.Query.TrimStart("?").ToString();
        var playerRecord = _db.GetPlayerRecordByUserName(nameString)
            .GetAwaiter()
            .GetResult();
        if (playerRecord is null)
            return false;

        var jObject = new JsonObject();
        jObject["netUserId"] = playerRecord.UserId.ToString();
        jObject["lastSeenName"] = playerRecord.LastSeenUserName;
        jObject["firstSeenTime"] = playerRecord.FirstSeenTime.ToString();
        jObject["lastSeenTime"] = playerRecord.LastSeenTime.ToString();

        await statusHandlerContext.RespondJsonAsync(jObject);
        return true;
    }
}
