using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoTabScript : MonoBehaviour {
    public PlayMenu Menu;
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Menu.DiffInfo();
        }
    }
}
