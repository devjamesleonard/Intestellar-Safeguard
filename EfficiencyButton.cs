using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfficiencyButton : MonoBehaviour {
    public Shop ShopArea;
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShopArea.OpenEfficient();
        }
    }
}
