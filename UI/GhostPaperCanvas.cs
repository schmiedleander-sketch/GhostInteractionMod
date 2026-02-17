using UnityEngine;
using UnityEngine.UI;

public class GhostPaperCanvas : MonoBehaviour
{
    private static Canvas _instance;

    public static Canvas Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject canvasObj = new GameObject("GhostPaperCanvas");
                _instance = canvasObj.AddComponent<Canvas>();
                _instance.renderMode = RenderMode.ScreenSpaceOverlay;

                CanvasScaler scaler = canvasObj.AddComponent<CanvasScaler>();
                scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;

                canvasObj.AddComponent<GraphicRaycaster>();
            }
            return _instance;
        }
    }
}
