using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsScript : MonoBehaviour {

    private ProductSwitcher productSwitcher;
    public static bool Sexchange = true;
    // Use this for initialization
    void Update () {
        //if (Sexchange == true)
        //{
        //    productSwitcher.defaultModel = true;
        //}
        //else if (Sexchange == false)
        //{
        //    productSwitcher.defaultModel = false;
        //}
        //else
        //{
        //    Debug.Log("Fejl");
        //}
    }
	
	public void SettingsChangeSexMale()
    {
        Sexchange = true;
        Debug.Log("Male");
    }
    public void SettingsChangeSexFemale()
    {
        Sexchange = false;
        Debug.Log("Female");
    }
}
