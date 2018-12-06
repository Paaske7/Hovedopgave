using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsScript : MonoBehaviour {

    public static bool isMale;
    public static bool showTutorial = false;
	
	public void ChangeSexToMale()
    {
        isMale = true;
        Debug.Log("Male");
        Debug.Log("Settings" + isMale);
    }
    public void ChangeSexToFemale()
    {
        isMale = false;
        Debug.Log("Female");
        Debug.Log("Settings" + isMale);
    }

    public void ShowToturial()
    {
        showTutorial = true;
    }
}
