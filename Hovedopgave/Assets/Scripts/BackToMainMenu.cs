using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class BackToMainMenu : MonoBehaviour {

    public void changemenuscene()
    {
        VuforiaBehaviour.Instance.enabled = false;
        SceneManager.LoadScene("MainMenuScene");
    }
}
