using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameButton : MonoBehaviour {
    public MainMenu Main;
	// Use this for initialization
	void Start () {
		
	}
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Main.MainGame();
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
