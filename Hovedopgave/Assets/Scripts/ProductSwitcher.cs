using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ProductSwitcher : MonoBehaviour
{

    // Use this for initialization
    private bool defaultModel;
    public GameObject modelPlaceHolder;
    private string currentModelName;

    private string itemSelected;
    public GameObject productPlaceHolder;
    private GameObject parentModel;

    public GameObject SelectedButton;

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
    private void Start()
    {
        defaultModel = true;
        parentModel = GameObject.Find("Product Models").GetComponent<GameObject>();
    }

    public void ChangeSex()
    {
        Debug.Log(defaultModel);

        if (defaultModel)
        {
            currentModelName = "xbot";
            modelPlaceHolder = Resources.Load<GameObject>("Prefabs/xbot");
            // modelPlaceHolder = AssetDatabase.LoadAssetAtPath("Assets/Prefabs/xbot", typeof(GameObject));
            Debug.Log(modelPlaceHolder);
            Debug.Log(currentModelName);
        }
        else
        {
            currentModelName = "ybot";
            modelPlaceHolder = Resources.Load<GameObject>("Prefabs/ybot");
            Debug.Log(modelPlaceHolder);
            Debug.Log(currentModelName);

        }

        foreach (GameObject Obj in Resources.FindObjectsOfTypeAll<GameObject>())
        {
            if (Obj.name == "xbot(Clone)" || Obj.name == "ybot(Clone)")
            {
                Destroy(Obj);
            }
        }
        Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0,180,0)); // instatiate a prefab on the position where the ray hits the floor.
        Debug.Log("Model er spawned");
        defaultModel = !defaultModel;


    }


    //public void SwitchProduct(string productID)
    //{
    //    //Tjek om produktet allerede er der
    //    //hvis det er så gør ikke noget (eller bare slet alt og forsæt?)
    //    foreach (GameObject Obj in Resources.FindObjectsOfTypeAll<GameObject>())
    //    {
    //        if (Obj.name == productID+"(Clone)")
    //        {
    //            Destroy(Obj);
    //        }
    //    }
    //    //ellers find produktet og instianser det
    //    //(Slå produktID op i DB for at finde filenavnet i appet?)
    //    productPlaceHolder = Resources.Load<GameObject>("Prefabs/Characters/"+productID);
    //    Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0)); // instatiate a prefab on the position where the ray hits the floor.
    //    Debug.Log("Produkt er spawned");
    //}
}
