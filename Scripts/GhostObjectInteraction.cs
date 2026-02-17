using UnityEngine;
using System.Collections;

public class GhostObjectInteraction : MonoBehaviour
{
    public float moveDistance = 1.5f;
    public float moveSpeed = 2.0f;

    public void MoveRandomObject(Vector3 ghostPos)
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Interactable"); // mark objects as interactable
        if (objects.Length == 0) return;

        GameObject obj = objects[Random.Range(0, objects.Length)];
        Vector3 randomOffset = new Vector3(
            Random.Range(-moveDistance, moveDistance),
            0,
            Random.Range(-moveDistance, moveDistance)
        );

        StartCoroutine(MoveCoroutine(obj.transform, randomOffset));
    }

    private IEnumerator MoveCoroutine(Transform obj, Vector3 offset)
    {
        Vector3 start = obj.position;
        Vector3 end = start + offset;
        float elapsed = 0;

        while (elapsed < 1f)
        {
            obj.position = Vector3.Lerp(start, end, elapsed);
            elapsed += Time.deltaTime * moveSpeed;
            yield return null;
        }

        obj.position = end;
    }
}
