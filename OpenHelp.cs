using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHelp : MonoBehaviour {
    public MainMenu man;
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            man.QuestionMark();
        }
    }
}
