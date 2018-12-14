using UnityEngine;

public class ProductSwitcher : MonoBehaviour
{
    public GameObject femaleCatalog;

    // Mikael Paaske og Thomas Nielsen
    public GameObject maleCatalog;
    private GameObject modelPlaceHolder;

    public void ChangeSex()
    {
        // Ændrer boolen fra Settingsscript til det omvendte
        SettingsScript.isMale = !SettingsScript.isMale;

        // Sletter alle modeller i scenen
        DestroyAll();

        // Loader enten den nøgne mand eller dame udfra boolen fra Settingsscript
        modelPlaceHolder =
            Resources.Load<GameObject>(SettingsScript.isMale ? "Prefabs/MaleNaked" : "Prefabs/FemaleNaked");

        // instansierer modellen i scenen
        Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
    }

    public void ShowCatalog()
    {
        // Tjekker om male og female catalog er aktiv i scenen
        if (maleCatalog.activeSelf || femaleCatalog.activeSelf) 
        {
            // Hvis de aktiv, sæt dem inaktiv
            maleCatalog.SetActive(false);
            femaleCatalog.SetActive(false);
        }
        else 
        {
            // Eller sæt dem aktiv
            if (SettingsScript.isMale)
                maleCatalog.SetActive(true);
            else
                femaleCatalog.SetActive(true);
        }
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