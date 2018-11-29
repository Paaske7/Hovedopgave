using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsScript : MonoBehaviour {

    public static bool Sexchange;
    public static bool showTutorial = false;
	
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

    public void ShowToturial()
    {
        showTutorial = true;
    }
}
