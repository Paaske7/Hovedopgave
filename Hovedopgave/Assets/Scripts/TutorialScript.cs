using UnityEngine;
public class TutorialScript : MonoBehaviour
{
    // Mikael Paaske

    // Henter bool fra Settingsscript
    bool showToturial = SettingsScript.showTutorial;

    private GameObject[] toturialTexts;

    void Start()
    {
        // Finder tekst objekterne i Unity
        toturialTexts = GameObject.FindGameObjectsWithTag("tutorial");

        // hvis showTutorial er true eller det første gang appen er blevet åbent bliver tutorial vist for brugeren
        if (showToturial || PlayerPrefs.GetInt("FIRSTTIMEOPENING", 1) == 1)
        {
            ShowToturial();
            // Gør den False igen, da tutorialen nu er blevet vist en gang mere. 
            SettingsScript.showTutorial = false;
        }
        else
        {
            DontShowTutorial();
        }
        
    }

    void ShowToturial()
    {
        // Sætter dem til True, det vil sige at de er synlige.
        foreach (var item in toturialTexts)
        {
            item.SetActive(true);
        }
        // Sætter "First Time Opening til False
        PlayerPrefs.SetInt("FIRSTTIMEOPENING", 0);

    }
    void DontShowTutorial()
    {
        // Sætter dem til False, det vil sige at de ikke bliver synlige.
        foreach (var item in toturialTexts)
        {
            item.SetActive(false);
        }
    }


    // Fjerner kun GameObjekter der har en Box Collider
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
