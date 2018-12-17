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

        if (isMale == true)
        {
            showSexText.GetComponent<Text>().text = "Mand";
            changeSexSlider.value = 1;
        }
        else if (isMale == false)
        {
            showSexText.GetComponent<Text>().text = "Kvinde";
            changeSexSlider.value = 0;
        }

        if (openInApp == true)
        {
            ønskeskyenText.GetComponent<Text>().text = "App";
            changeWebSiteSlider.value = 1;
        }
        else if (openInApp == false)
        {
            ønskeskyenText.GetComponent<Text>().text = "Hjemmeside";
            changeWebSiteSlider.value = 0;
        }

        if (showTutorial == true)
        {
            tutorialText.GetComponent<Text>().text = "Vis";
            changeTutorial.value = 1;
        }
        else if (showTutorial == false)
        {
            tutorialText.GetComponent<Text>().text = "Vis Ikke";
            changeTutorial.value = 0;
        }
    }

    public void Update()
    {
        // Ændrer farve på gameobjektet alt efter hvilken tekst der står ovenover
        if (showSexText.GetComponent<Text>().text == "Kvinde")
        {
            backgroundchangeSexSlider.color = Color.red;
        }


        if (tutorialText.GetComponent<Text>().text == "Vis Ikke")
        {
            backgroundchangeTutorial.color = Color.red;
        }


        if (ønskeskyenText.GetComponent<Text>().text == "Hjemmeside")
        {
            backggroundchangeWebSiteSlider.color = Color.red;
        }
    }
    public void ChangeSex(float changeSexFloat)
    {
        if (changeSexFloat == 1)
        {
            showSexText.GetComponent<Text>().text = "Mand";
            isMale = true;
        }
        else if (changeSexFloat == 0)
        {
            showSexText.GetComponent<Text>().text = "Kvinde";
            isMale = false;
        }
    }

   
    public void WishList(float openInAppFloat)
    {
        if (openInAppFloat == 1)
        {
            ønskeskyenText.GetComponent<Text>().text = "App";
            openInApp = true;
        }
        else if (openInAppFloat == 0)
        {
            ønskeskyenText.GetComponent<Text>().text = "Hjemmeside";
            openInApp = false;
        }
      
    }

    public void ShowToturial(float showTutorialFloat)
    {
        if (showTutorialFloat == 1)
        {
            tutorialText.GetComponent<Text>().text = "Vis";
            showTutorial = true;
        }
        else if (showTutorialFloat == 0)
        {
            tutorialText.GetComponent<Text>().text = "Vis ikke";
            showTutorial = false;
        }
    }
}
