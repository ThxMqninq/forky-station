using Robust.Shared.Configuration;

namespace Content.Shared._Qippe.QVars;

public sealed partial class QVars
{
    public static readonly CVarDef<bool> ForceCapitalize =
        CVarDef.Create("chat.force_capitalize", false, CVar.SERVER);
}
