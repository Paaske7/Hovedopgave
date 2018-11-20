using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class MenuChanger : MonoBehaviour {
    // Mikael Paaske
    public void changemenusceneMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
    public void changemenusceneAboutUs()
    {
        SceneManager.LoadScene("AboutUsScene");
    }
    public void changemenusceneScanClothScene()
    {
        SceneManager.LoadScene("ScanClothScene");
    }
    public void changemenuscenePoseScene()
    {
        SceneManager.LoadScene("PoseScene");
    }
}
