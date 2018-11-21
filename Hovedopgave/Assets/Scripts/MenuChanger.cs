using UnityEngine;
using UnityEngine.SceneManagement;

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
    public void changemenusceneWishList()
    {
        SceneManager.LoadScene("WishListScene");
    }
}
