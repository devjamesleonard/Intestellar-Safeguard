using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewFinder : MonoBehaviour {
    public MenuScrip Menu;
    public float Change;
    public int Popint;
    public int S;
   //public GameObject This;
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(PlaySFX(Menu.Game.OpenPlaces));
            Menu.Popint = Popint;
            Menu.TemperatureChange = Change;
            Menu.SolarChange = this.name.ToString();
            if(Popint == 6)
            {
                Popint = 7;
            }else if(Popint == 7)
            {
                Popint = 8;
            }else if(Popint == 8)
            {
                Popint = 6;
            }
        }
    }
    IEnumerator PlaySFX(AudioClip Clip)
    {

        Menu.Game.SFX.clip = Clip;
        Menu.Game.SFX.Play();
        yield return new WaitForSeconds(Menu.Game.SFX.clip.length * 2);

    }
}
