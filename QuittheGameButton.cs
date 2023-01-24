using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuittheGameButton : MonoBehaviour {
    public BeginScript Main;
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Main.QuitGame();
        }
    }
}
