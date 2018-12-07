using UnityEngine;

public class SettingsScript : MonoBehaviour {

    // Mikael Paaske
    public static bool isMale;
    public static bool showTutorial;
	
	public void ChangeSexToMale()
    {
        // Hvis tryk på knappen "Mand" i indstillinger menuen bliver boolen sat til true
        isMale = true;
    }
    public void ChangeSexToFemale()
    {
        // Hvis tryk på knappen "Kvinde" i indstillinger menuen bliver boolen sat til false
        isMale = false;
    }

    public void ShowToturial()
    {
        // Sætter boolen til True, så tutorial kan blive vist igen
        showTutorial = true;
    }
}
