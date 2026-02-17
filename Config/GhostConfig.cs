public static class GhostConfig
{
    // Fixed durations, distances, and UI settings
    public const float ObjectMoveDistance = 1.5f;
    public const float ObjectMoveSpeed = 2.0f;

    public const float PaperVanishTime = 10f;
    public const float PossessionDuration = 5f;

    public const int PaperFontSize = 20;

    // Messages ghosts can leave (read-only)
    public static readonly string[] Hints = new string[]
    {
        "Check near Electrical.",
        "Lights flickered in MedBay.",
        "Someone passed Admin.",
        "Door feels locked in Storage."
    };
}
