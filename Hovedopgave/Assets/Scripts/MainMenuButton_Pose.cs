using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class MainMenuButton_Pose : MonoBehaviour {

    public void changemenuscene()
    {
        SceneManager.LoadScene("PoseScene");
    }
}
