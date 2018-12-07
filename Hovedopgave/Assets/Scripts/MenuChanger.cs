using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuChanger : MonoBehaviour {
    // Mikael Paaske
    // Disse ændrer scenen i vores mobilaplikation

    public void changemenusceneMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
    public void changemenusceneSettings()
    {
        SceneManager.LoadScene("SettingsScene");
    }
    public void changemenusceneScanClothScene()
    {
        SceneManager.LoadScene("ScanClothScene");
    }
    public void changemenuscenePoseScene()
    {
        SceneManager.LoadScene("ShowroomScene");
    }
}
