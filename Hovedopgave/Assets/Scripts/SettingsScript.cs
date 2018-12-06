using UnityEngine;

public class SettingsScript : MonoBehaviour {

    public static bool isMale;
    public static bool showTutorial;
	
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
