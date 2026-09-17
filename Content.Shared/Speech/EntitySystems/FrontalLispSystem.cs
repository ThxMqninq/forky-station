using System.Text.RegularExpressions;
using Content.Shared.Speech.Components;

namespace Content.Shared.Speech.EntitySystems;

public sealed partial class FrontalLispSystem : RelayAccentSystem<FrontalLispComponent>
{
    // @formatter:off
    private static readonly Regex RegexUpperTh = new("[T]+[Ss]+|[S]+[Cc]+(?=[IiEeYy]+)|[C]+(?=[IiEeYy]+)|[P][Ss]+|([S]+[Tt]+|[T]+)(?=[Ii]+[Oo]+[Uu]*[Nn]*)|[C]+[Hh]+(?=[Ii]*[Ee]*)|[Z]+|[S]+|[X]+(?=[Ee]+)");
    private static readonly Regex RegexLowerTh = new("[t]+[s]+|[s]+[c]+(?=[iey]+)|[c]+(?=[iey]+)|[p][s]+|([s]+[t]+|[t]+)(?=[i]+[o]+[u]*[n]*)|[c]+[h]+(?=[i]*[e]*)|[z]+|[s]+|[x]+(?=[e]+)");
    private static readonly Regex RegexUpperEcks = new("[E]+[Xx]+[Cc]*|[X]+");
    private static readonly Regex RegexLowerEcks = new("[e]+[x]+[c]*|[x]+");
    private static readonly Regex RegexLowerC = new Regex("с");
    private static readonly Regex RegexUpperC = new Regex("С");
    private static readonly Regex RegexLowerCh = new Regex("ч");
    private static readonly Regex RegexUpperCh = new Regex("Ч");
    private static readonly Regex RegexLowerTs = new Regex("ц");
    private static readonly Regex RegexUpperTs = new Regex("Ц");
    private static readonly Regex RegexLowerT = new Regex(@"\B[т](?![АЕЁИОУЫЭЮЯаеёиоуыэюя])");
    private static readonly Regex RegexUpperT = new Regex(@"\B[Т](?![АЕЁИОУЫЭЮЯаеёиоуыэюя])");
    private static readonly Regex RegexLowerZ = new Regex("з");
    private static readonly Regex RegexUpperZ = new Regex("З");
    // @formatter:on

    public override string Accentuate(string message, Entity<FrontalLispComponent>? ent = null)
    {
        // handles ts, sc(i|e|y), c(i|e|y), ps, st(io(u|n)), ch(i|e), z, s
        message = RegexUpperTh.Replace(message, "TH");
        message = RegexLowerTh.Replace(message, "th");
        // handles ex(c), x
        message = RegexUpperEcks.Replace(message, "EKTH");
        message = RegexLowerEcks.Replace(message, "ekth");
        message = RegexLowerC.Replace(message, "с");
        message = RegexUpperC.Replace(message, "С");
        message = RegexLowerCh.Replace(message, "ч");
        message = RegexUpperCh.Replace(message, "Ч");
        message = RegexLowerTs.Replace(message, "ц");
        message = RegexUpperTs.Replace(message, "Ц");
        message = RegexLowerT.Replace(message, "т");
        message = RegexUpperT.Replace(message, "Т");
        message = RegexLowerZ.Replace(message, "з");
        message = RegexUpperZ.Replace(message, "З");
        return message;
    }
}
