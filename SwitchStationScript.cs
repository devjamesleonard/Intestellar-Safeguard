using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStationScript : MonoBehaviour {
    public DataTableScrip Data;
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Data.StationSend();
        }
    }
}
