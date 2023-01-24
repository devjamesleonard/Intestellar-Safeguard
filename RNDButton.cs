using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RNDButton : MonoBehaviour {
    public Shop ShopArea;
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShopArea.OpenRND();
        }
    }
}
