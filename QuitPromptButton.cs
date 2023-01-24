using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitPromptButton : MonoBehaviour {
    public BeginScript Main;
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Main.ChangeQuit();
        }
    }
}
