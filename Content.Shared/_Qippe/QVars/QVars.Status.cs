using Robust.Shared.Configuration;

namespace Content.Shared._Qippe.QVars;

public sealed partial class QVars
{
    public static readonly CVarDef<bool> StatusPlayerList =
        CVarDef.Create("status.player_list", true, CVar.SERVER | CVar.SERVERONLY | CVar.ARCHIVE);

    public static readonly CVarDef<bool> StatusPlayerRecord =
        CVarDef.Create("status.player_record", true, CVar.SERVER | CVar.SERVERONLY | CVar.ARCHIVE);

    public static readonly CVarDef<bool> StatusBanNote =
        CVarDef.Create("status.ban_note", true, CVar.SERVER | CVar.SERVERONLY | CVar.ARCHIVE);
}
