using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuCanvas : MonoBehaviour {
    // Mikael Paaske

    // Instansierer gameobjekter
    private GameObject canvas;
    private GameObject homeButton;
    private GameObject ClothScannerButton;
    private GameObject showroomButton;
    private GameObject settingsButton;
    private GameObject panel;
    private Scene currentScene;



   
    void Start () {
        // Finder gameobjekter i scenen
        canvas = GameObject.Find("MenuCanvas");
        panel = canvas.transform.Find("Panel").gameObject;
        homeButton = panel.transform.Find("HomeButton").gameObject;
        ClothScannerButton = panel.transform.Find("ClothScannerButton").gameObject;
        showroomButton = panel.transform.Find("ShowroomButton").gameObject;
        settingsButton = panel.transform.Find("SettingsButton").gameObject;

    }
	

	void Update () {
        // Finder den aktive scene
        currentScene = SceneManager.GetActiveScene();

        // Ændrer farven på knapperne på canvaset ud fra hvilken scene der er valgt
        if (currentScene.name == "MainMenuScene")
        {
            homeButton.GetComponent<Image>().color = Color.grey;
        }

        else if (currentScene.name == "ScanClothScene")
        {
            ClothScannerButton.GetComponent<Image>().color = Color.grey;
        }

        else if (currentScene.name == "ShowroomScene")
        {
            showroomButton.GetComponent<Image>().color = Color.grey;
        }

        else if (currentScene.name == "SettingsScene")
        {
            settingsButton.GetComponent<Image>().color = Color.grey;
        }
    }
}
