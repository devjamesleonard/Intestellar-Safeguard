using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScript : MonoBehaviour {
    public Howtoplay Smoked;
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Smoked.Next();
        }
    }
}
