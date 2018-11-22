using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ProductCatalogUI : MonoBehaviour {

    private GameObject parentUI;
    void Start () {
        parentUI = GameObject.Find("Product Catalog");
	    GameObject ProductCatalogButton = Resources.Load<GameObject>("Prefabs/CatalogItem");

        for (int i = 0; i < 5; i++)
	    {
	        GameObject tempButton = Instantiate(ProductCatalogButton, new Vector3(100,750-(i*50),0), Quaternion.Euler(0, 0, 0)); // instatiate a prefab on the position where the ray hits the floor.
            tempButton.transform.SetParent(parentUI.transform);
        }
        //Idag har vi forsat arbejdet med opgaverne der blev fordelt igår.

        //   //find alle produkter der er tilgængelige
        //   //for hvert produkt laves et UI element (billed med produktnavn) 
        //   //      -(lav så det tilpasses skærmen (forskellige telefoner har forskellige bredde osv.) 
        //   //      -f.eks. 3x4 grid eller 4x3, 2x6?
        //   //      -brug Unity Scaler? https://docs.unity3d.com/Manual/script-CanvasScaler.html
        //   //      -tving mellemrum mellem alle elementer down & left 10px
        //   //klikkes et af disse UI knapper loades et 3dobjekt svarende til det valgte produkt
        //   string filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        //DirectoryInfo d = new DirectoryInfo(filepath);

        //foreach (var file in d.GetFiles("*.txt"))
        //{
        //    Directory.Move(file.FullName, filepath + "\\TextFiles\\" + file.Name);
        //}

        //   //DirectoryInfo dir = new DirectoryInfo(homeDir);
        //   //DirectoryInfo[] info = dir.GetDirectories("*.*");
        //   //int count = dir.GetDirectories().Length;
        //   //for (int i = 0; i < count; i++)
        //   //{
        //   //    Debug.Log("Found Directory: " + info[i]);
        //   //}
    }


}
