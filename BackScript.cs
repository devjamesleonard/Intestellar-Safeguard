using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackScript : MonoBehaviour {
    public Howtoplay Menu;
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Menu.Back();
        }
    }
}
