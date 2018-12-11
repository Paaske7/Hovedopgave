using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuCanvas : MonoBehaviour {

    private GameObject canvas;
    private GameObject homeButton;
    private GameObject ClothScannerButton;
    private GameObject showroomButton;
    private GameObject settingsButton;
    private Scene currentScene;



    // Use this for initialization
    void Start () {
        canvas = GameObject.Find("MenuCanvas");
        homeButton = canvas.transform.Find("HomeButton").gameObject;
        ClothScannerButton = canvas.transform.Find("ClothScannerButton").gameObject;
        showroomButton = canvas.transform.Find("ShowroomButton").gameObject;
        settingsButton = canvas.transform.Find("SettingsButton").gameObject;

    }
	
	// Update is called once per frame
	void Update () {
        currentScene = SceneManager.GetActiveScene();

        if (currentScene.name == "MainMenuScene")
        {
            homeButton.GetComponent<Image>().color = Color.red;
        }

        else if (currentScene.name == "ScanClothScene")
        {
            ClothScannerButton.GetComponent<Image>().color = Color.red;
        }

        else if (currentScene.name == "ShowroomScene")
        {
            showroomButton.GetComponent<Image>().color = Color.red;
        }

        else if (currentScene.name == "SettingsScene")
        {
            settingsButton.GetComponent<Image>().color = Color.red;
        }
    }
}
