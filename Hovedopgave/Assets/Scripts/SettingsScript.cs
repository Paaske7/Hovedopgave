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

    public Slider changeSexSlider;
    public Image backgroundchangeSexSlider;

    public Slider changeWebSiteSlider;
    public Image backggroundchangeWebSiteSlider;

    public Slider changeTutorial;
    public Image backgroundchangeTutorial;

    public void Start()
    {
        // Finder alle de nødvendige gameobjekter i scenen 
        canvas = GameObject.Find("SettingsCanvas");
        showSexText = canvas.transform.Find("ShowSexText").gameObject;
        ønskeskyenText = canvas.transform.Find("ShowØnskeskyenText").gameObject;
        tutorialText = canvas.transform.Find("ShowToturialText").gameObject;

        changeSexSlider = GameObject.Find("ChangeSexSlider").GetComponent<Slider>();
        backgroundchangeSexSlider = GameObject.FindGameObjectWithTag("background").GetComponent<Image>();

        changeWebSiteSlider = GameObject.Find("ØnskeskyenSlider").GetComponent<Slider>();
        backggroundchangeWebSiteSlider = GameObject.FindGameObjectWithTag("backgground2").GetComponent<Image>();

        changeTutorial = GameObject.Find("TutorialSlider").GetComponent<Slider>();
        backgroundchangeTutorial = GameObject.FindGameObjectWithTag("backgground3").GetComponent<Image>();
    }

    public void Update()
    {
        // Ændrer farve på gameobjektet alt efter hvilken tekst der står ovenover
        if (showSexText.GetComponent<Text>().text == "Kvinde")
        {
            backgroundchangeSexSlider.color = Color.red;
        }


        if (tutorialText.GetComponent<Text>().text == "Vis ikke")
        {
            backgroundchangeTutorial.color = Color.red;
        }


        if (ønskeskyenText.GetComponent<Text>().text == "Hjemmeside")
        {
            backggroundchangeWebSiteSlider.color = Color.red;
        }
    }
    public void ChangeSex()
    {
        // Hvis slider bliver rykket til den ene ende, bliver boolen sat til det modsatte af før
        isMale = !isMale;
        Debug.Log(isMale);
        // Ændrer gameobjektets tekst til det modsatte efter slideren er rykket
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
            backgroundchangeTutorial.color = Color.blue;
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
            backggroundchangeWebSiteSlider.color = Color.blue;
        }
    }
}
