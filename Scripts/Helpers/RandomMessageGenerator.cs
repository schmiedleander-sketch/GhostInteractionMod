using UnityEngine;

public static class RandomMessageGenerator
{
    private static string[] hints = new string[]
    {
        "Check near Electrical.",
        "Lights flickered in MedBay.",
        "Someone passed Admin.",
        "Door feels locked in Storage."
    };

    public static string GetRandomHint()
    {
        return hints[Random.Range(0, hints.Length)];
    }
}
