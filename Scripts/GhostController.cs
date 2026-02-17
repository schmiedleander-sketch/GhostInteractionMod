using UnityEngine;

public class GhostController : MonoBehaviour
{
    public GhostObjectInteraction objectInteraction;
    public GhostSabotage sabotage;
    public GhostPaper paper;

    void Update()
    {
        // Example: Ghost presses keys to trigger actions (testing)
        if (Input.GetKeyDown(KeyCode.O))
            objectInteraction.MoveRandomObject(transform.position);

        if (Input.GetKeyDown(KeyCode.L))
            sabotage.TriggerRandomLight();

        if (Input.GetKeyDown(KeyCode.D))
            sabotage.TriggerRandomDoor();

        if (Input.GetKeyDown(KeyCode.P))
        {
            string hint = RandomMessageGenerator.GetRandomHint();
            paper.LeavePaper(transform.position, hint);
        }
    }
}
