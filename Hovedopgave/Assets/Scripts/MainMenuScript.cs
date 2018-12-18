using UnityEngine;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour {
    
    // Mikael Paaske

    // Instansierer gameobjekter
    private GameObject welcome;
    private GameObject canvas;

    private GameObject newsText1;

    void Start () {

        // Finder gameobjekter i scenen
        canvas = GameObject.Find("Canvas");
        welcome = canvas.transform.Find("WelcomeText").gameObject;
        newsText1 = canvas.transform.Find("NewsText1").gameObject;

        // Her skal kundes ændrer, hvis nye nyheder skal vises
        newsText1.GetComponent<Text>().text = "Husk 50% på alt d. 31 Januar!!";

        // Tjekker om det er første gang appen er åben, hvis det er ændres tekstfeltets text til velkommen, ellers velkommen tilbage
        if (PlayerPrefs.GetInt("FIRSTTIMEOPENING", 1) == 1)
        {
            welcome.GetComponent<Text>().text = "Velkommen!";
        }
        else
        {
            welcome.GetComponent<Text>().text = "Velkommen tilbage!";
        }
	}
}
