using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton_ClothScanner : MonoBehaviour {

 
	public void changemenuscene()
    {
        SceneManager.LoadScene("ScanClothScene");
    }
}
