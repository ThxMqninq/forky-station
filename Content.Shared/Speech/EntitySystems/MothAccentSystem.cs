using System.Text.RegularExpressions;
using Content.Shared.Speech.Components;

namespace Content.Shared.Speech.EntitySystems;

public sealed partial class MothAccentSystem : RelayAccentSystem<MothAccentComponent>
{
    private static readonly Regex RegexLowerBuzz = new("z{1,3}");
    private static readonly Regex RegexUpperBuzz = new("Z{1,3}");
    private static readonly Regex RegexLowerZh = new Regex("ж+");
    private static readonly Regex RegexUpperZh = new Regex("Ж+");
    private static readonly Regex RegexLowerZ = new Regex("з+");
    private static readonly Regex RegexUpperZ = new Regex("З+");

    public override string Accentuate(string message, Entity<MothAccentComponent>? ent = null)
    {
        // buzzz
        message = RegexLowerBuzz.Replace(message, "zzz");
        // buZZZ
        message = RegexUpperBuzz.Replace(message, "ZZZ");
        message = RegexLowerZh.Replace(message, "жжж");
        message = RegexUpperZh.Replace(message, "ЖЖЖ");
        message = RegexLowerZ.Replace(message, "ззз");
        message = RegexUpperZ.Replace(message, "ЗЗЗ");

        return message;
    }
}
