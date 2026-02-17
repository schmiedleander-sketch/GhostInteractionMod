using UnityEngine;
using UnityEngine.UI;

public class GhostPaper : MonoBehaviour
{
    private Canvas worldCanvas => GhostPaperCanvas.Instance;
    
    public void LeavePaper(Vector3 position, string message)
    {
        GameObject note = new GameObject("GhostNote");
        note.transform.SetParent(worldCanvas.transform);

        Text text = note.AddComponent<Text>();
        text.text = message;
        text.fontSize = GhostConfig.PaperFontSize;
        text.color = new Color(1f, 1f, 1f, 0.8f);
        text.alignment = TextAnchor.MiddleCenter;

        RectTransform rect = text.GetComponent<RectTransform>();
        Vector3 screenPos = Camera.main.WorldToScreenPoint(position);
        rect.position = screenPos;
        rect.sizeDelta = new Vector2(200, 50);

        Destroy(note, GhostConfig.PaperVanishTime);
    }
}
