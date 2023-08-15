using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelControl : MonoBehaviour
{
    public float slideDuration;
    public bool hide;
    public RectTransform panel;
    public Vector2 DefPos;
    public Vector2 HidePos;
    public Transform camera;
    public Vector3 cameraDefPos;
    public Vector3 cameraHidePos;
    public Transform btn;

    // Start is called before the first frame update
    void Start()
    {
        DefPos = panel.anchoredPosition;
        cameraDefPos = camera.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowHide()
    {
        if (hide == false)
        {
            //panel.anchoredPosition = HidePos;
            hide = true;
            StartCoroutine(Slide(slideDuration, DefPos, HidePos, cameraDefPos, cameraHidePos));
            btn.Rotate(new Vector3(0, 0, 180));
        }
        else
        {
            panel.anchoredPosition = DefPos;
            hide = false;
            StartCoroutine(Slide(slideDuration, HidePos, DefPos, cameraHidePos, cameraDefPos));
            btn.Rotate(new Vector3(0, 0, 180));
        }
    }

    IEnumerator Slide(float inputTimer, Vector2 StartPoint, Vector2 Destination, Vector3 CamStart, Vector3 CamDest)
    {
        float elapsedTime = 0;
        float timer = inputTimer;
        while (elapsedTime < timer)
        {
            panel.anchoredPosition = Vector2.Lerp(StartPoint, Destination, elapsedTime / timer);
            camera.localPosition = Vector3.Lerp(CamStart, CamDest, elapsedTime / timer);
            elapsedTime = elapsedTime + Time.deltaTime;
            yield return null;
        }
    }
}
