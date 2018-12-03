using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ProductSwitcher : MonoBehaviour
{
    // Mikael Paaske
    // Laver en ny bool og sætter den = bool fra SettingsScript
    bool getSexchangeFromSettings = SettingsScript.Sexchange;

    // Thomas Nielsen
    public bool defaultModel = true;
    public GameObject modelPlaceHolder;
    private string currentModelName;
    SettingsScript settingsScript;
    private string itemSelected;
    public GameObject SelectedButton;

    private void Start()
    {
        // Mikael Paaske
        // checkter om knappen fra Settings er trykket på - Det vil sige om der er trykket skift køn 
        if (getSexchangeFromSettings == false)
        {
            modelPlaceHolder = Resources.Load<GameObject>("Prefabs/m01_naked_00_h");
            Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
        }
        else if (getSexchangeFromSettings == true)
        {
            modelPlaceHolder = Resources.Load<GameObject>("Prefabs/m01_schoolwear_000_h");
            Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
        }
        else
        {
            modelPlaceHolder = Resources.Load<GameObject>("Prefabs/m01_naked_00_h");
            Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
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
        Debug.Log(defaultModel);

        if (defaultModel)
        {
            currentModelName = "m01_naked_00_h";
            modelPlaceHolder = Resources.Load<GameObject>("Prefabs/m01_naked_00_h");
            Debug.Log(modelPlaceHolder);
            Debug.Log(currentModelName);
        }
        else
        {
            currentModelName = "m01_schoolwear_000_h";
            modelPlaceHolder = Resources.Load<GameObject>("Prefabs/m01_schoolwear_000_h");
            Debug.Log(modelPlaceHolder);
            Debug.Log(currentModelName);

        }

        foreach (GameObject Obj in Resources.FindObjectsOfTypeAll<GameObject>())
        {
            if (Obj.name == "m01_naked_00_h(Clone)" || Obj.name == "m01_schoolwear_000_h(Clone)")
            {
                Destroy(Obj);
            }
        }
        Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0,180,0));
        Debug.Log("Model er spawned");
        defaultModel = !defaultModel;


    }
}
