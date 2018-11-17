using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class BackToMainMenu : MonoBehaviour {
    // Mikael Paaske
    public void changemenuscene()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
