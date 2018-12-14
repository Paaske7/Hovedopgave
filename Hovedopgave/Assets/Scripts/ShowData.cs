using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{
    // Mikael Paaske & Thomas Nielsen
    private ProductUrlHandler _productUrlHandler;
    private List<ProductItem> clothesInfoList;
    private Database DB;

    public Text DescriptionTextField;

    public Text nameTextField;
    public Text PriceTextField;
    public Text FabricTextField1;

    public void Start()
    {
        _productUrlHandler = GameObject.Find("GameController").GetComponent<ProductUrlHandler>();
        DB = GameObject.Find("DatabaseHandler").GetComponent<Database>();
    }

    public void CallDatabaseQRCode1()
    {
        // Henter alt data om produktet QR-koden peger på og gemmer disse som properties i en liste af ProductItem 
        clothesInfoList = DB.GetclothesInfoListQRCode1();

        //For hvert tekstfelt (Name, Price, Description og Fabrics) findes den pågældende UI element i scenen
        //Teksten i UI elementet bliver sat til informationen fra databasen
        //Hvis der ikke er nogen information på en property f.eks. Name bliver UI teksten istedet sat til 'Ikke oplyst'
        nameTextField = GameObject.Find("QRCode1_Name").GetComponent<Text>();
        nameTextField.text = (clothesInfoList[0].Name).Equals(string.Empty) ? "Ikke oplyst" : clothesInfoList[0].Name;


        PriceTextField = GameObject.Find("QRCode1_Price").GetComponent<Text>();
        PriceTextField.text = (clothesInfoList[0].Price.Equals(string.Empty) ? "Ikke oplyst" :  clothesInfoList[0].Price+" kroner");

        DescriptionTextField = GameObject.Find("QRCode1_Description").GetComponent<Text>();
        DescriptionTextField.text = (clothesInfoList[0].Description.Equals(string.Empty) ? "Ikke oplyst" : clothesInfoList[0].Description);

        //Ud fra 4 felter i databasen der har information om fabrics tilføjes disse til UI-teksten med linieskift hvis ikke de er tomme
        FabricTextField1 = GameObject.Find("QRCode1_Fabrics").GetComponent<Text>();
        FabricTextField1.text = (clothesInfoList[0].Fabric1.Equals(string.Empty) ? "Ikke oplyst" : "-" + clothesInfoList[0].Fabric1) + 
                                (clothesInfoList[0].Fabric2.Equals(string.Empty) ? "" : "\n -"+ clothesInfoList[0].Fabric2)+
                                (clothesInfoList[0].Fabric3.Equals(string.Empty) ? "" : "\n -" + clothesInfoList[0].Fabric3)+
                                (clothesInfoList[0].Fabric4.Equals(string.Empty) ? "" : "\n -" + clothesInfoList[0].Fabric4);

        //Sætter produkt linket i ProductURLHandler scriptet
        _productUrlHandler.ProductUrl = clothesInfoList[0].URL;

        //Sletter informationer gemt i listen af ProductItems
        clothesInfoList.Clear();
    }
    public void CallDatabaseQRCode2()
    {
        // Henter alt data om produktet QR-koden peger på og gemmer disse som properties i en liste af ProductItem 
        clothesInfoList = DB.GetclothesInfoListQRCode2();

        //For hvert tekstfelt (Name, Price, Description og Fabrics) findes den pågældende UI element i scenen
        //Teksten i UI elementet bliver sat til informationen fra databasen
        //Hvis der ikke er nogen information på en property f.eks. Name bliver UI teksten istedet sat til 'Ikke oplyst'
        nameTextField = GameObject.Find("QRCode2_Name").GetComponent<Text>();
        nameTextField.text = (clothesInfoList[0].Name).Equals(string.Empty) ? "Ikke oplyst" : clothesInfoList[0].Name;


        PriceTextField = GameObject.Find("QRCode2_Price").GetComponent<Text>();
        PriceTextField.text = (clothesInfoList[0].Price.Equals(string.Empty) ? "Ikke oplyst" : clothesInfoList[0].Price + " kroner");

        DescriptionTextField = GameObject.Find("QRCode2_Description").GetComponent<Text>();
        DescriptionTextField.text = (clothesInfoList[0].Description.Equals(string.Empty) ? "Ikke oplyst" : clothesInfoList[0].Description);

        //Ud fra 4 felter i databasen der har information om fabrics tilføjes disse til UI-teksten med linieskift hvis ikke de er tomme
        FabricTextField1 = GameObject.Find("QRCode2_Fabrics").GetComponent<Text>();
        FabricTextField1.text = (clothesInfoList[0].Fabric1.Equals(string.Empty) ? "Ikke oplyst" : "-" + clothesInfoList[0].Fabric1) +
                                (clothesInfoList[0].Fabric2.Equals(string.Empty) ? "" : "\n -" + clothesInfoList[0].Fabric2) +
                                (clothesInfoList[0].Fabric3.Equals(string.Empty) ? "" : "\n -" + clothesInfoList[0].Fabric3) +
                                (clothesInfoList[0].Fabric4.Equals(string.Empty) ? "" : "\n -" + clothesInfoList[0].Fabric4);

        //Sætter produkt linket i ProductURLHandler scriptet
        _productUrlHandler.ProductUrl = clothesInfoList[0].URL;

        //Sletter informationer gemt i listen af ProductItems
        clothesInfoList.Clear();
    }

    public void CallDatabaseQRCode3()
    {
        // Henter alt data om produktet QR-koden peger på og gemmer disse som properties i en liste af ProductItem 
        clothesInfoList = DB.GetclothesInfoListQRCode3();

        //For hvert tekstfelt (Name, Price, Description og Fabrics) findes den pågældende UI element i scenen
        //Teksten i UI elementet bliver sat til informationen fra databasen
        //Hvis der ikke er nogen information på en property f.eks. Name bliver UI teksten istedet sat til 'Ikke oplyst'
        nameTextField = GameObject.Find("QRCode3_Name").GetComponent<Text>();
        nameTextField.text = (clothesInfoList[0].Name).Equals(string.Empty) ? "Ikke oplyst" : clothesInfoList[0].Name;

        PriceTextField = GameObject.Find("QRCode3_Price").GetComponent<Text>();
        PriceTextField.text = (clothesInfoList[0].Price.Equals(string.Empty) ? "Ikke oplyst" : clothesInfoList[0].Price + " kroner");

        DescriptionTextField = GameObject.Find("QRCode3_Description").GetComponent<Text>();
        DescriptionTextField.text = (clothesInfoList[0].Description.Equals(string.Empty) ? "Ikke oplyst" : clothesInfoList[0].Description);

        //Ud fra 4 felter i databasen der har information om fabrics tilføjes disse til UI-teksten med linieskift hvis ikke de er tomme
        FabricTextField1 = GameObject.Find("QRCode3_Fabrics").GetComponent<Text>();
        FabricTextField1.text = (clothesInfoList[0].Fabric1.Equals(string.Empty) ? "Ikke oplyst" : "-" + clothesInfoList[0].Fabric1) +
                                (clothesInfoList[0].Fabric2.Equals(string.Empty) ? "" : "\n -" + clothesInfoList[0].Fabric2) +
                                (clothesInfoList[0].Fabric3.Equals(string.Empty) ? "" : "\n -" + clothesInfoList[0].Fabric3) +
                                (clothesInfoList[0].Fabric4.Equals(string.Empty) ? "" : "\n -" + clothesInfoList[0].Fabric4);

        //Sætter produkt linket i ProductURLHandler scriptet
        _productUrlHandler.ProductUrl = clothesInfoList[0].URL;

        //Sletter informationer gemt i listen af ProductItems
        clothesInfoList.Clear();
    }

    public void CallDatabaseQRCode4()
    {
        // Henter alt data om produktet QR-koden peger på og gemmer disse som properties i en liste af ProductItem 
        clothesInfoList = DB.GetclothesInfoListQRCode4();

        //For hvert tekstfelt (Name, Price, Description og Fabrics) findes den pågældende UI element i scenen
        //Teksten i UI elementet bliver sat til informationen fra databasen
        //Hvis der ikke er nogen information på en property f.eks. Name bliver UI teksten istedet sat til 'Ikke oplyst'
        nameTextField = GameObject.Find("QRCode4_Name").GetComponent<Text>();
        nameTextField.text = (clothesInfoList[0].Name).Equals(string.Empty) ? "Ikke oplyst" : clothesInfoList[0].Name;


        PriceTextField = GameObject.Find("QRCode4_Price").GetComponent<Text>();
        PriceTextField.text = (clothesInfoList[0].Price.Equals(string.Empty) ? "Ikke oplyst" : clothesInfoList[0].Price + " kroner");

        DescriptionTextField = GameObject.Find("QRCode4_Description").GetComponent<Text>();
        DescriptionTextField.text = (clothesInfoList[0].Description.Equals(string.Empty) ? "Ikke oplyst" : clothesInfoList[0].Description);

        //Ud fra 4 felter i databasen der har information om fabrics tilføjes disse til UI-teksten med linieskift hvis ikke de er tomme
        FabricTextField1 = GameObject.Find("QRCode4_Fabrics").GetComponent<Text>();
        FabricTextField1.text = (clothesInfoList[0].Fabric1.Equals(string.Empty) ? "Ikke oplyst" : "-" + clothesInfoList[0].Fabric1) +
                                (clothesInfoList[0].Fabric2.Equals(string.Empty) ? "" : "\n -" + clothesInfoList[0].Fabric2) +
                                (clothesInfoList[0].Fabric3.Equals(string.Empty) ? "" : "\n -" + clothesInfoList[0].Fabric3) +
                                (clothesInfoList[0].Fabric4.Equals(string.Empty) ? "" : "\n -" + clothesInfoList[0].Fabric4);

        //Sætter produkt linket i ProductURLHandler scriptet
        _productUrlHandler.ProductUrl = clothesInfoList[0].URL;

        //Sletter informationer gemt i listen af ProductItems
        clothesInfoList.Clear();
    }
}