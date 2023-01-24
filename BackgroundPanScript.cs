using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundPanScript : MonoBehaviour {
    public CameraMotion Camera;
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Camera.Started();
        }
    }
}
