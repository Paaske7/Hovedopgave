using UnityEngine;

public class ProductSwitcher : MonoBehaviour
{
    // Mikael Paaske
    // Laver en ny bool og sætter den = bool fra SettingsScript

    private GameObject modelPlaceHolder;
    private GameObject button1Male;
    private GameObject button2Male;
    private GameObject button3Male;
    private GameObject button4Male;
    private GameObject button1Female;
    private GameObject button2Female;
    private GameObject button3Female;
    private GameObject button4Female;

    // Thomas Nielsen og Mikael Paaske

    /*Load alle nye modeller ind i projektet under 'Models>Products>data/sæson
    Alle tilgængelige produkter findes fra databasen og vises i en menu så brugeren kan vælge
    Når brugeren vælger et produkt bruges info fra DB til at finde modelNavnet
    Modellen bliver vist i Unity
    brugeren kan vælge et nyt produkt hvorefter den forrige bliver fjernet(Man kunne lave noget kategorisering så man både kan vise bukser og trøjer samtidig)
    lav seperat kode til visning og valg af produkter
    grid med billed og tekst der virker som en knap til at vælge produkt med
    laves automatisk baseret på de tilgængelige produkter
    Mobil controls er lidt bæ
    Kan ikke kigge nedefra
    lav knap til reset af kamera?
    lav simple pile til rotering?
    sæt en fast scale for prefabs så en par jeans ikke er 8 meter høj*/

    private void Start()
    {
        Debug.Log("Productswitcher isMale:" + SettingsScript.isMale);
        // Mikael Paaske
        //DestroyAll();
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
        SettingsScript.isMale = !SettingsScript.isMale;
        DestroyAll();
        Debug.Log("SexChange isMale:" + SettingsScript.isMale);

        modelPlaceHolder =
            Resources.Load<GameObject>(SettingsScript.isMale ? "Prefabs/MaleNaked" : "Prefabs/FemaleNaked");
        Debug.Log("modelPlaceHolder :" + modelPlaceHolder.name);

        SetButtonStates();

        Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
        Debug.Log("Model er spawned");
    }

    public void SetButtonStates()
    {
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