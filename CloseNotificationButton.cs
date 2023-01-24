using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseNotificationButton : MonoBehaviour {
    public MenuScrip Menu;
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Menu.CloseNotify();
        }
    }
}
