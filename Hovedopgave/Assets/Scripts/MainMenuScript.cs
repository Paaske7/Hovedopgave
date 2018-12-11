using UnityEngine;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour {
    
    // Mikael Paaske

    // Instansierer gameobjekter
    private GameObject welcome;
    private GameObject canvas;

    private GameObject newsText1;
    private GameObject newsText2;
    private GameObject newsText3;

    void Start () {

        // Finder gameobjekter i scenen
        canvas = GameObject.Find("MenuCanvas");
        welcome = canvas.transform.Find("WelcomeText").gameObject;
        newsText1 = canvas.transform.Find("NewsText1").gameObject;
        newsText2 = canvas.transform.Find("NewsText2").gameObject;
        newsText3 = canvas.transform.Find("NewsText3").gameObject;

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
