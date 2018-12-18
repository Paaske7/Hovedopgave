using UnityEngine;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour {

    // Mikael Paaske
    public static bool isMale;
    public static bool showTutorial;
    public static bool openInApp;

    public GameObject canvas;

    public GameObject showSexText;
    public GameObject showØnskeskyenText;
    public GameObject showTutorialText;

    public Slider changeSexSlider;
    public Image backgroundchangeSexSlider;

    public Slider changeWebSiteSlider;
    public Image backggroundchangeWebSiteSlider;

    public Slider changeTutorialSlider;
    public Image backgroundchangeTutorialSlider;

    public void Start()
    {
        // Finder alle de nødvendige gameobjekter i scenen 
        canvas = GameObject.Find("SettingsCanvas");

        showSexText = canvas.transform.Find("ShowSexText").gameObject;
        showØnskeskyenText = canvas.transform.Find("ShowØnskeskyenText").gameObject;
        showTutorialText = canvas.transform.Find("ShowToturialText").gameObject;

        changeSexSlider = GameObject.Find("ChangeSexSlider").GetComponent<Slider>();
        backgroundchangeSexSlider = GameObject.FindGameObjectWithTag("background").GetComponent<Image>();

        changeWebSiteSlider = GameObject.Find("ØnskeskyenSlider").GetComponent<Slider>();
        backggroundchangeWebSiteSlider = GameObject.FindGameObjectWithTag("backgground2").GetComponent<Image>();

        changeTutorialSlider = GameObject.Find("TutorialSlider").GetComponent<Slider>();
        backgroundchangeTutorialSlider = GameObject.FindGameObjectWithTag("backgground3").GetComponent<Image>();

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
            showØnskeskyenText.GetComponent<Text>().text = "App";
            changeWebSiteSlider.value = 1;
        }
        else if (openInApp == false)
        {
            showØnskeskyenText.GetComponent<Text>().text = "Hjemmeside";
            changeWebSiteSlider.value = 0;
        }

        if (showTutorial == true)
        {
            showTutorialText.GetComponent<Text>().text = "Vis";
            changeTutorialSlider.value = 1;
        }
        else if (showTutorial == false)
        {
            showTutorialText.GetComponent<Text>().text = "Vis Ikke";
            changeTutorialSlider.value = 0;
        }
    }

    public void Update()
    {
        // Ændrer farve på gameobjektet alt efter hvilken tekst der står ovenover
        if (showSexText.GetComponent<Text>().text == "Kvinde")
        {
            backgroundchangeSexSlider.color = Color.red;
        }


        if (showTutorialText.GetComponent<Text>().text == "Vis Ikke")
        {
            backgroundchangeTutorialSlider.color = Color.red;
        }


        if (showØnskeskyenText.GetComponent<Text>().text == "Hjemmeside")
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
            showØnskeskyenText.GetComponent<Text>().text = "App";
            openInApp = true;
        }
        else if (openInAppFloat == 0)
        {
            showØnskeskyenText.GetComponent<Text>().text = "Hjemmeside";
            openInApp = false;
        }
      
    }

    public void ShowToturial(float showTutorialFloat)
    {
        if (showTutorialFloat == 1)
        {
            showTutorialText.GetComponent<Text>().text = "Vis";
            showTutorial = true;
        }
        else if (showTutorialFloat == 0)
        {
            showTutorialText.GetComponent<Text>().text = "Vis ikke";
            showTutorial = false;
        }
    }
}
