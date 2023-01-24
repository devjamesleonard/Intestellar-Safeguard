using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiffSwapScript : MonoBehaviour {
    public PlayMenu Menu;
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Menu.Difficulty(); 
        }
    }
}
