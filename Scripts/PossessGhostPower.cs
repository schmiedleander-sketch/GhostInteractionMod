using UnityEngine;
using System.Collections;

public class PossessGhostPower : MonoBehaviour
{
    public float possessionDuration = 5f;
    private bool isPossessing = false;

    public void Possess(GameObject impostor)
    {
        if (!isPossessing)
            StartCoroutine(PossessionCoroutine(impostor));
    }

    private IEnumerator PossessionCoroutine(GameObject impostor)
    {
        isPossessing = true;

        GhostSabotage ghostPower = impostor.AddComponent<GhostSabotage>();
        ghostPower.TriggerRandomLight(); // example instant boost

        yield return new WaitForSeconds(possessionDuration);

        Destroy(ghostPower);
        isPossessing = false;
    }
}
