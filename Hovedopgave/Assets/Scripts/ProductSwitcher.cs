using UnityEngine;

public class ProductSwitcher : MonoBehaviour
{
    // Mikael Paaske
    private GameObject modelPlaceHolder;
    private GameObject button1Male;
    private GameObject button2Male;
    private GameObject button3Male;
    private GameObject button4Male;
    private GameObject button1Female;
    private GameObject button2Female;
    private GameObject button3Female;
    private GameObject button4Female;

    private void Start()
    {
        // Finder alle knapperne i scenen.
        button1Male = GameObject.Find("MaleBlackJacket");
        button2Male = GameObject.Find("MalePantsBlue");
        button3Male = GameObject.Find("MaleTShirtWhite");
        button4Male = GameObject.Find("MaleUnderPantsBlack");

        button1Female = GameObject.Find("FemaleBlackShoes");
        button2Female = GameObject.Find("FemaleBlackUnderPants");
        button3Female = GameObject.Find("FemaleBlueDress");
        button4Female = GameObject.Find("FemaleGreenJacket");

        SetButtonStates();
    }

    public void ChangeSex()
    {
        // Ændrer boolen fra Settingsscript til det omvendte
        SettingsScript.isMale = !SettingsScript.isMale;

        // Sletter alle modeller i scenen
        DestroyAll();

        // Loader enten den nøgne mand eller dame udfra boolen fra Settingsscript
        modelPlaceHolder =
            Resources.Load<GameObject>(SettingsScript.isMale ? "Prefabs/MaleNaked" : "Prefabs/FemaleNaked");

        // Viser hvilke knapper der skal vises i scenen
        SetButtonStates();

        // instansierer modellen i scenen
        Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
    }

    public void SetButtonStates()
    {
        // Funktion at vise knapperne i scenen for enten om det er en mand der bliver vist eller en dame
        button1Male.SetActive(SettingsScript.isMale);
        button2Male.SetActive(SettingsScript.isMale);
        button3Male.SetActive(SettingsScript.isMale);
        button4Male.SetActive(SettingsScript.isMale);

        button1Female.SetActive(!SettingsScript.isMale);
        button2Female.SetActive(!SettingsScript.isMale);
        button3Female.SetActive(!SettingsScript.isMale);
        button4Female.SetActive(!SettingsScript.isMale);
    }
    private void DestroyAll()
    {
        // Sletter alle modeller i scenen
        foreach (var Obj in Resources.FindObjectsOfTypeAll<GameObject>())
            if (Obj.name == "FemaleNaked(Clone)" || Obj.name == "FemaleBlackShoes(Clone)" ||
                Obj.name == "FemaleBlackUnderPants(Clone)" ||
                Obj.name == "FemaleBlueDress(Clone)" || Obj.name == "FemaleGreenJacket(Clone)" ||
                Obj.name == "MaleBlackJacket(Clone)" || Obj.name == "MaleNaked(Clone)"
                || Obj.name == "MalePantsBlue(Clone)" || Obj.name == "MaleTShirtWhite(Clone)" ||
                Obj.name == "MaleUnderPantsBlack(Clone)")
                Destroy(Obj);
    }
}