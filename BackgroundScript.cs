using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour { 
    public GameCode Game;
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Game.OptionsMenu();
        }
    }
}
