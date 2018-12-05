using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ProductSwitcher : MonoBehaviour
{
    // Mikael Paaske
    // Laver en ny bool og sætter den = bool fra SettingsScript
    public static bool getSexchangeFromSettings = SettingsScript.Sexchange;
 
    GameObject button1Male;
    GameObject button2Male;
    GameObject button3Male;
    GameObject button4Male;

    GameObject button1Female;
    GameObject button2Female;
    GameObject button3Female;
    GameObject button4Female;

    // Thomas Nielsen
    public DisplayProduct displayProduct;
    public GameObject modelPlaceHolder;
    private string currentModelName;
    SettingsScript settingsScript;
    private string itemSelected;
    public GameObject SelectedButton;


    private void Start()
    {
        // Mikael Paaske
        DestroyAll();
        button1Male = GameObject.Find("MaleBlackJacket");
        button2Male = GameObject.Find("MalePantsBlue");
        button3Male = GameObject.Find("MaleTShirtWhite");
        button4Male = GameObject.Find("MaleUnderPantsBlack");

        button1Female = GameObject.Find("FemaleBlackShoes");
        button2Female = GameObject.Find("FemaleBlackUnderPants");
        button3Female = GameObject.Find("FemaleBlueDress");
        button4Female = GameObject.Find("FemaleGreenJacket");

        if (getSexchangeFromSettings == true)
        {
            button1Male.SetActive(true);
            button2Male.SetActive(true);
            button3Male.SetActive(true);
            button4Male.SetActive(true);

            button1Female.SetActive(false);
            button2Female.SetActive(false);
            button3Female.SetActive(false);
            button4Female.SetActive(false);
        }
        else if(getSexchangeFromSettings == false)
        {
            button1Male.SetActive(false);
            button2Male.SetActive(false);
            button3Male.SetActive(false);
            button4Male.SetActive(false);

            button1Female.SetActive(true);
            button2Female.SetActive(true);
            button3Female.SetActive(true);
            button4Female.SetActive(true);
        }
    }


    // Thomas Nielsen og Mikael Paaske
    //Load alle nye modeller ind i projektet under 'Models>Products>data/sæson
    //Alle tilgængelige produkter findes fra databasen og vises i en menu så brugeren kan vælge
    //Når brugeren vælger et produkt bruges info fra DB til at finde modelNavnet
    //Modellen bliver vist i Unity
    //brugeren kan vælge et nyt produkt hvorefter den forrige bliver fjernet (Man kunne lave noget kategorisering så man både kan vise bukser og trøjer samtidig)
    //lav seperat kode til visning og valg af produkter
    //grid med billed og tekst der virker som en knap til at vælge produkt med
    //laves automatisk baseret på de tilgængelige produkter
    //Mobil controls er lidt bæ
    //Kan ikke kigge nedefra
    //lav knap til reset af kamera?
    //lav simple pile til rotering ?
    //sæt en fast scale for prefabs så en par jeans ikke er 8 meter høj
    public void ChangeSex()
    {
  

        if (getSexchangeFromSettings)
        {
            DestroyAll();
            currentModelName = "FemaleNaked";
            modelPlaceHolder = Resources.Load<GameObject>("Prefabs/FemaleNaked");
            Debug.Log(modelPlaceHolder);
            Debug.Log(currentModelName);
            button1Male.SetActive(false);
            button2Male.SetActive(false);
            button3Male.SetActive(false);
            button4Male.SetActive(false);

            button1Female.SetActive(true);
            button2Female.SetActive(true);
            button3Female.SetActive(true);
            button4Female.SetActive(true);

        }
        else
        {
            DestroyAll();
            currentModelName = "MaleNaked";
            modelPlaceHolder = Resources.Load<GameObject>("Prefabs/MaleNaked");
            Debug.Log(modelPlaceHolder);
            Debug.Log(currentModelName);
            button1Male.SetActive(true);
            button2Male.SetActive(true);
            button3Male.SetActive(true);
            button4Male.SetActive(true);

            button1Female.SetActive(false);
            button2Female.SetActive(false);
            button3Female.SetActive(false);
            button4Female.SetActive(false);


        }
     
      
        Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0,180,0));
        Debug.Log("Model er spawned");
        getSexchangeFromSettings = !getSexchangeFromSettings;


    }
    void DestroyAll()
    {
        foreach (GameObject Obj in Resources.FindObjectsOfTypeAll<GameObject>())
        {
            if (Obj.name == "FemaleNaked(Clone)" || Obj.name == "FemaleBlackShoes(Clone)" || Obj.name == "FemaleBlackUnderPants(Clone)" ||
                Obj.name == "FemaleBlueDress(Clone)" || Obj.name == "FemaleGreenJacket(Clone)" || Obj.name == "MaleBlackJacket(Clone)" || Obj.name == "MaleNaked(Clone)"
                || Obj.name == "MalePantsBlue(Clone)" || Obj.name == "MaleTShirtWhite(Clone)" || Obj.name == "MaleUnderPantsBlack(Clone)")
            {
                Destroy(Obj);
            }
        }
    }
}
