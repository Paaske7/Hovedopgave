using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{
    // Mikael Paaske
    private ProductUrlHandler _productUrlHandler;
    private List<ProductItem> clothesInfoList;
    private Database DB;

    public Text DescriptionTextField;

    public Text nameTextField;
    public Text PriceTextField;
    public Text FabricTextField1;
    public Text Fabric2TextField;
    public Text Fabric3TextField;
    public Text Fabric4TextField;

    public void Start()
    {
        _productUrlHandler = GameObject.Find("GameController").GetComponent<ProductUrlHandler>();
        DB = GameObject.Find("DatabaseHandler").GetComponent<Database>();
    }

    public void CallDatabaseQRCode1()
    {
        // Henter alt data fra properties i ProductItem og sætter dem på vores tekst gameobjekter i scenen
        clothesInfoList = DB.GetclothesInfoListQRCode1();

        nameTextField = GameObject.Find("QRCode1_Name").GetComponent<Text>();
        nameTextField.text = (clothesInfoList[0].Name).Equals(string.Empty) ? "Ikke oplyst" : clothesInfoList[0].Name;


        PriceTextField = GameObject.Find("QRCode1_Price").GetComponent<Text>();
        PriceTextField.text = (clothesInfoList[0].Price.Equals(string.Empty) ? "Ikke oplyst" :  clothesInfoList[0].Price+" kroner");

        DescriptionTextField = GameObject.Find("QRCode1_Description").GetComponent<Text>();
        DescriptionTextField.text = (clothesInfoList[0].Description.Equals(string.Empty) ? "Ikke oplyst" : clothesInfoList[0].Description);

        FabricTextField1 = GameObject.Find("QRCode1_Fabrics").GetComponent<Text>();
        FabricTextField1.text = (clothesInfoList[0].Fabric1.Equals(string.Empty) ? "Ikke oplyst" : "-" + clothesInfoList[0].Fabric1) + 
                                (clothesInfoList[0].Fabric2.Equals(string.Empty) ? "" : "\n -"+ clothesInfoList[0].Fabric2)+
                                (clothesInfoList[0].Fabric3.Equals(string.Empty) ? "" : "\n -" + clothesInfoList[0].Fabric3)+
                                (clothesInfoList[0].Fabric4.Equals(string.Empty) ? "" : "\n -" + clothesInfoList[0].Fabric4);


        //Fabric2TextField = GameObject.Find("QRCode1_Fabric2").GetComponent<Text>();
        //Fabric2TextField.text = clothesInfoList[0].Fabric2;
        
        //Fabric3TextField = GameObject.Find("QRCode1_Fabric3").GetComponent<Text>();
        //Fabric3TextField.text = clothesInfoList[0].Fabric3;

        //Fabric4TextField = GameObject.Find("QRCode1_Fabric4").GetComponent<Text>();
        //Fabric4TextField.text = clothesInfoList[0].Fabric4;

        _productUrlHandler.ProductUrl = clothesInfoList[0].URL;

        clothesInfoList.Clear();
    }

    public void CallDatabaseQRCode2()
    {
        // Henter alt data fra properties i ProductItem og sætter dem på vores tekst gameobjekter i scenen
        clothesInfoList = DB.GetclothesInfoListQRCode2();

        nameTextField = GameObject.Find("QRCode2_Name").GetComponent<Text>();
        nameTextField.text = clothesInfoList[0].Name;

        PriceTextField = GameObject.Find("QRCode2_Price").GetComponent<Text>();
        PriceTextField.text = clothesInfoList[0].Price + " kroner";

        DescriptionTextField = GameObject.Find("QRCode2_Description").GetComponent<Text>();
        DescriptionTextField.text = clothesInfoList[0].Description;

        FabricTextField1 = GameObject.Find("QRCode2_Fabric1").GetComponent<Text>();
        FabricTextField1.text = clothesInfoList[0].Fabric1;

        Fabric2TextField = GameObject.Find("QRCode2_Fabric2").GetComponent<Text>();
        Fabric2TextField.text = clothesInfoList[0].Fabric2;

        Fabric3TextField = GameObject.Find("QRCode2_Fabric3").GetComponent<Text>();
        Fabric3TextField.text = clothesInfoList[0].Fabric3;

        Fabric4TextField = GameObject.Find("QRCode2_Fabric4").GetComponent<Text>();
        Fabric4TextField.text = clothesInfoList[0].Fabric4;

        _productUrlHandler.ProductUrl = clothesInfoList[0].URL;

        clothesInfoList.Clear();
    }

    public void CallDatabaseQRCode3()
    {
        // Henter alt data fra properties i ProductItem og sætter dem på vores tekst gameobjekter i scenen
        clothesInfoList = DB.GetclothesInfoListQRCode3();

        nameTextField = GameObject.Find("QRCode3_Name").GetComponent<Text>();
        nameTextField.text = clothesInfoList[0].Name;

        PriceTextField = GameObject.Find("QRCode3_Price").GetComponent<Text>();
        PriceTextField.text = clothesInfoList[0].Price + " kroner";

        DescriptionTextField = GameObject.Find("QRCode3_Description").GetComponent<Text>();
        DescriptionTextField.text = clothesInfoList[0].Description;

        FabricTextField1 = GameObject.Find("QRCode3_Fabric1").GetComponent<Text>();
        FabricTextField1.text = clothesInfoList[0].Fabric1;

        Fabric2TextField = GameObject.Find("QRCode3_Fabric2").GetComponent<Text>();
        Fabric2TextField.text = clothesInfoList[0].Fabric2;

        Fabric3TextField = GameObject.Find("QRCode3_Fabric2").GetComponent<Text>();
        Fabric3TextField.text = clothesInfoList[0].Fabric3;

        Fabric4TextField = GameObject.Find("QRCode3_Fabric2").GetComponent<Text>();
        Fabric4TextField.text = clothesInfoList[0].Fabric4;

        _productUrlHandler.ProductUrl = clothesInfoList[0].URL;

        clothesInfoList.Clear();
    }

    public void CallDatabaseQRCode4()
    {
        // Henter alt data fra properties i ProductItem og sætter dem på vores tekst gameobjekter i scenen
        clothesInfoList = DB.GetclothesInfoListQRCode4();

        nameTextField = GameObject.Find("QRCode4_Name").GetComponent<Text>();
        nameTextField.text = clothesInfoList[0].Name;

        PriceTextField = GameObject.Find("QRCode4_Price").GetComponent<Text>();
        PriceTextField.text = clothesInfoList[0].Price + " kroner";

        DescriptionTextField = GameObject.Find("QRCode4_Description").GetComponent<Text>();
        DescriptionTextField.text = clothesInfoList[0].Description;

        FabricTextField1 = GameObject.Find("QRCode4_Fabric1").GetComponent<Text>();
        FabricTextField1.text = clothesInfoList[0].Fabric1;

        Fabric2TextField = GameObject.Find("QRCode4_Fabric2").GetComponent<Text>();
        Fabric2TextField.text = clothesInfoList[0].Fabric2;

        Fabric3TextField = GameObject.Find("QRCode4_Fabric3").GetComponent<Text>();
        Fabric3TextField.text = clothesInfoList[0].Fabric3;

        Fabric4TextField = GameObject.Find("QRCode4_Fabric4").GetComponent<Text>();
        Fabric4TextField.text = clothesInfoList[0].Fabric4;

        _productUrlHandler.ProductUrl = clothesInfoList[0].URL;

        clothesInfoList.Clear();
    }
}