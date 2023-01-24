using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenProgressScript : MonoBehaviour {

    public BeginScript Game;
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Game.Choose();
        }
    }
}
