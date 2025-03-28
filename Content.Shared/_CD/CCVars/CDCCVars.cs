using Robust.Shared.Configuration;

namespace Content.Shared._CD.CCVars;

/// <summary>
/// CD Specific Cvars
/// </summary>
[CVarDefs]
public sealed class CDCCVars
{
    /// <summary>
    /// Respawn time, how long the player has to wait in seconds after death before they can respawn.
    /// </summary>
    public static readonly CVarDef<float> RespawnTime =
        CVarDef.Create("cd.game.respawn_time", 300.0f, CVar.SERVER | CVar.REPLICATED);

    /// <summary>
    /// Calendar CVars.
    /// </summary>
    public static readonly CVarDef<int> DaysPerYear =
        CVarDef.Create("cd.calendar.DaysPerYear", 320, CVar.SERVER | CVar.REPLICATED);

    public static readonly CVarDef<int> DaysPerMonth =
        CVarDef.Create("cd.calendar.DaysPerMonth", 32,  CVar.SERVER | CVar.REPLICATED);

    public static readonly CVarDef<int> DaysPerWeek =
        CVarDef.Create("cd.calendar.DaysPerWeek", 8,  CVar.SERVER | CVar.REPLICATED);
}
