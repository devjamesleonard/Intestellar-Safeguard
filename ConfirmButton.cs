using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmButton : MonoBehaviour {
    public Shop ShopArea;
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShopArea.Select();
        }
    }
}
