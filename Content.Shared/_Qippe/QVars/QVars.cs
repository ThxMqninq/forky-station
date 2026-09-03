using Robust.Shared;
using Robust.Shared.Configuration;

namespace Content.Shared._Qippe.QVars;

[CVarDefs]
public sealed partial class QVars : CVars
{
    // ShaderPrototype
    public static readonly CVarDef<int> SelectedLobbyShader =
        CVarDef.Create("lobby.shader_proto", 1, CVar.CLIENTONLY | CVar.ARCHIVE);

    // Top & Bottom colors for all lobby shaders
    public static readonly CVarDef<string> GradientColorTop =
        CVarDef.Create("lobby.gradient_bottom_color", "#FF9B32FF", CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<string> GradientColorBottom =
        CVarDef.Create("lobby.gradient_top_color", "#C83CC8FF", CVar.CLIENTONLY | CVar.ARCHIVE);

    // lobby.gradient_clouds
    // Gradient clouds shader

    public static readonly CVarDef<int> GradientCloudsLayerCount =
        CVarDef.Create("lobby.gradient_clouds_layer_count", 40, CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<float> GradientCloudsTimeScale =
        CVarDef.Create("lobby.gradient_clouds_time_scale", 0.2f, CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<float> GradientCloudsBaseIntensity =
        CVarDef.Create("lobby.gradient_clouds_base_intensity", 0.5f, CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<float> GradientCloudsSize =
        CVarDef.Create("lobby.gradient_clouds_size", 0.7f, CVar.CLIENTONLY | CVar.ARCHIVE);

    // lobby.gradient_ocean
    // Gradient ocean shader

    public static readonly CVarDef<float> GradientOceanWaveAmplitude =
        CVarDef.Create("lobby.gradient_ocean_wave_amp", 0.25f, CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<float> GradientOceanWaveSize =
        CVarDef.Create("lobby.gradient_ocean_wave_size", 5f, CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<float> GradientOceanWaveTimeMultiplier =
        CVarDef.Create("lobby.gradient_ocean_wave_time_mul", 0.2f, CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<int> GradientOceanTotalPhases =
        CVarDef.Create("lobby.gradient_ocean_total_phases", 40, CVar.CLIENTONLY | CVar.ARCHIVE);
}
