using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeavePlayMenuButton : MonoBehaviour {
    public PlayMenu Play;
	// Use this for initialization

    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Play.MainGame();
        }
    }

}
