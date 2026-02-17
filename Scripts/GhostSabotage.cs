using UnityEngine;

public class GhostSabotage : MonoBehaviour
{
    public void TriggerRandomLight()
    {
        // Calls existing Among Us sabotage code (pseudo-code)
        GameManager.Instance.SetLightsSabotage(true, 5f);
    }

    public void TriggerRandomDoor()
    {
        // Lock a random door for 3 seconds
        Door[] doors = GameManager.Instance.GetAllDoors();
        if (doors.Length == 0) return;

        Door door = doors[Random.Range(0, doors.Length)];
        door.LockForSeconds(3f);
    }
}
