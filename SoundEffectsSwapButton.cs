﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectsSwapButton : MonoBehaviour {

    public SettingsMenu Settin;

    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Settin.switchSFXvol();
        }
    }
}
