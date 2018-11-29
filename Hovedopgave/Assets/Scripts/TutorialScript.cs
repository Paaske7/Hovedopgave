using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialScript : MonoBehaviour
{
    // Mikael Paaske

    // Henter bool fra Settingsscript
    bool showToturial = SettingsScript.showTutorial;

    private GameObject toturialText1;
    private GameObject toturialText2;
    private GameObject toturialText3;
    private GameObject toturialText4;
    private GameObject toturialText5;
    private GameObject toturialText6;
    private GameObject toturialText7;
    private GameObject toturialText8;

    void Start()
    {
        // Finder tekst objekterne i Unity
        toturialText1 = GameObject.Find("TutorialText1");
        toturialText2 = GameObject.Find("TutorialText2");
        toturialText3 = GameObject.Find("TutorialText3");
        toturialText4 = GameObject.Find("TutorialText4");
        toturialText5 = GameObject.Find("TutorialText5");
        toturialText6 = GameObject.Find("TutorialText6");
        toturialText7 = GameObject.Find("TutorialText7");
        toturialText8 = GameObject.Find("TutorialText8");


        if (showToturial == true || PlayerPrefs.GetInt("FIRSTTIMEOPENING", 1) == 1)
        {
            ShowToturial();
            // Gør den False igen, da tutorialen nu er blevet vist en gang mere. 
            SettingsScript.showTutorial = false;
        }
        else
        {
            DontShowTutorial();
        }
        
    }

    void ShowToturial()
    {
        // Sætter dem til True, det vil sige at de er synlige.
        toturialText1.SetActive(true);
        toturialText2.SetActive(true);
        toturialText3.SetActive(true);
        toturialText4.SetActive(true);
        toturialText5.SetActive(true);
        toturialText6.SetActive(true);
        toturialText7.SetActive(true);
        toturialText8.SetActive(true);
        Debug.Log("First Time Opening");

        // Sætter "First Time Opening til False
        PlayerPrefs.SetInt("FIRSTTIMEOPENING", 0);

    }
    void DontShowTutorial()
    {
        // Sætter dem til False, det vil sige at de ikke bliver synlige.
        Debug.Log("NOT First Time Opening");
        toturialText1.SetActive(false);
        toturialText2.SetActive(false);
        toturialText3.SetActive(false);
        toturialText4.SetActive(false);
        toturialText5.SetActive(false);
        toturialText6.SetActive(false);
        toturialText7.SetActive(false);
        toturialText8.SetActive(false);
        //Do your stuff here
    }
    // Fjerner kun GameObjekter der har en Box Collider
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
