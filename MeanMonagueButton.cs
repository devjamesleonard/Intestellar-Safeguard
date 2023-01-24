using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeanMonagueButton : MonoBehaviour {
    public SettingsMenu Settin;
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Settin.MainMonue();
        }
    }
}
