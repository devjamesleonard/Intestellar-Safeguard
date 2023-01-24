using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGame : MonoBehaviour {

    public MainMenu Main;
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Main.LoadNewGame();
        }
    }
}
