using UnityEngine;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour {

    // Mikael Paaske
    public static bool isMale;
    public static bool showTutorial;
    public static bool openInApp;

    public GameObject canvas;
    public GameObject showSexText;
    public GameObject ønskeskyenText;
    public GameObject tutorialText;

    public void Start()
    {
        canvas = GameObject.Find("SettingsCanvas");
        showSexText = canvas.transform.Find("ShowSexText").gameObject;
        ønskeskyenText = canvas.transform.Find("ShowØnskeskyenText").gameObject;
        tutorialText = canvas.transform.Find("ShowToturialText").gameObject;

    }
	public void ChangeSex()
    {
        // Hvis slider bliver rykket til den ene ende, bliver boolen sat til det modsatte af før
        isMale = !isMale;

        // Ændrer gameobjektets tekst ud fra boolen er sand eller falsk
        if (isMale == true)
        {
            showSexText.GetComponent<Text>().text = "Mand";
        }
        else if (isMale == false)
        {
            showSexText.GetComponent<Text>().text = "Kvinde";
        }
    }

    public void ShowToturial()
    {
        // Hvis slider bliver rykket til den ene ende, bliver boolen sat til det modsatte af før
        showTutorial = !showTutorial;

        // Ændrer gameobjektets tekst ud fra boolen er sand eller falsk
        if (showTutorial == true)
        {
            tutorialText.GetComponent<Text>().text = "Vis";
        }
        else if (showTutorial == false)
        {
            tutorialText.GetComponent<Text>().text = "Vis ikke";
        }  
    }
    public void WishList()
    {
        // Hvis slider bliver rykket til den ene ende, bliver boolen sat til det modsatte af før
        openInApp = !openInApp;

        // Ændrer gameobjektets tekst ud fra boolen er sand eller falsk
        if (openInApp == true)
        {
            ønskeskyenText.GetComponent<Text>().text = "App";
        }
        else if (openInApp == false)
        {
            ønskeskyenText.GetComponent<Text>().text = "Hjemmeside";
        }
    }
}
