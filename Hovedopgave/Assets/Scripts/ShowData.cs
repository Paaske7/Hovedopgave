using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{
    //Mikael Paaske
    public Text nameTextField;
    public Text PriceTextField;
    public Text DescriptionTextField;
    public Text QualityTextField;
    public Text Quality2TextField;
    public Text Quality3TextField;
    public Text Quality4TextField;
    //public Text URLTextField;
    private Database DB;
    private CopyToClipboard _copyToClipboard;

    public void Start()
    {
        _copyToClipboard = GameObject.Find("GameController").GetComponent<CopyToClipboard>();

    }
    public void CallDatabaseQRCode1()
    {
        {
            DB = GameObject.Find("DatabaseHandler").GetComponent<Database>();
            List<Cloth> clothesInfoList;
            clothesInfoList = DB.GetclothesInfoListQRCode1();

            nameTextField = GameObject.Find("QRCode1_Name").GetComponent<Text>();
            nameTextField.text = clothesInfoList[0].Name;

            PriceTextField = GameObject.Find("QRCode1_Price").GetComponent<Text>();
            PriceTextField.text = clothesInfoList[0].Price;

            DescriptionTextField = GameObject.Find("QRCode1_Description").GetComponent<Text>();
            DescriptionTextField.text = clothesInfoList[0].Description;

            QualityTextField = GameObject.Find("QRCode1_Quality").GetComponent<Text>();
            QualityTextField.text = clothesInfoList[0].Quality;

            Quality2TextField = GameObject.Find("QRCode1_Quality2").GetComponent<Text>();
            Quality2TextField.text = clothesInfoList[0].Quality2;

            Quality3TextField = GameObject.Find("QRCode1_Quality3").GetComponent<Text>();
            Quality3TextField.text = clothesInfoList[0].Quality3;

            Quality4TextField = GameObject.Find("QRCode1_Quality4").GetComponent<Text>();
            Quality4TextField.text = clothesInfoList[0].Quality4;

            _copyToClipboard.ProductUrl = clothesInfoList[0].URL;

            //URLTextField.text = clothesInfoList[0].URL;
            //GameController.GetComponent<CopyToClipboard>().ProductUrl = clothesInfoList[0].URL;
            Debug.Log("Product URL SD: " + clothesInfoList[0].URL);

            Debug.Log("ShowData - QRCode1 End");
        }
    }
    public void CallDatabaseQRCode2()
    {
        DB = GameObject.Find("DatabaseHandler").GetComponent<Database>();
        List<Cloth> clothesInfoList;
        clothesInfoList = DB.GetclothesInfoListQRCode2();

        nameTextField = GameObject.Find("QRCode2_Name").GetComponent<Text>();
        nameTextField.text = clothesInfoList[0].Name;

        PriceTextField = GameObject.Find("QRCode2_Price").GetComponent<Text>();
        PriceTextField.text = clothesInfoList[0].Price;

        DescriptionTextField = GameObject.Find("QRCode2_Description").GetComponent<Text>();
        DescriptionTextField.text = clothesInfoList[0].Description;

        QualityTextField = GameObject.Find("QRCode2_Quality").GetComponent<Text>();
        QualityTextField.text = clothesInfoList[0].Quality;

        Quality2TextField = GameObject.Find("QRCode2_Quality2").GetComponent<Text>();
        Quality2TextField.text = clothesInfoList[0].Quality2;

        Quality3TextField = GameObject.Find("QRCode2_Quality3").GetComponent<Text>();
        Quality3TextField.text = clothesInfoList[0].Quality3;

        Quality4TextField = GameObject.Find("QRCode2_Quality4").GetComponent<Text>();
        Quality4TextField.text = clothesInfoList[0].Quality4;

        _copyToClipboard.ProductUrl = clothesInfoList[0].URL;
        //URLTextField.text = clothesInfoList[0].URL;

        Debug.Log("ShowData - QRCode2 End");
    }

    public void CallDatabaseQRCode3()
    {
        DB = GameObject.Find("DatabaseHandler").GetComponent<Database>();
        List<Cloth> clothesInfoList;
        clothesInfoList = DB.GetclothesInfoListQRCode3();

        nameTextField = GameObject.Find("QRCode3_Name").GetComponent<Text>();
        nameTextField.text = clothesInfoList[0].Name;

        PriceTextField = GameObject.Find("QRCode3_Price").GetComponent<Text>();
        PriceTextField.text = clothesInfoList[0].Price;

        DescriptionTextField = GameObject.Find("QRCode3_Description").GetComponent<Text>();
        DescriptionTextField.text = clothesInfoList[0].Description;

        QualityTextField = GameObject.Find("QRCode3_Quality").GetComponent<Text>();
        QualityTextField.text = clothesInfoList[0].Quality;

        Quality2TextField = GameObject.Find("QRCode3_Quality2").GetComponent<Text>();
        Quality2TextField.text = clothesInfoList[0].Quality2;

        Quality3TextField = GameObject.Find("QRCode3_Quality2").GetComponent<Text>();
        Quality3TextField.text = clothesInfoList[0].Quality3;

        Quality4TextField = GameObject.Find("QRCode3_Quality2").GetComponent<Text>();
        Quality4TextField.text = clothesInfoList[0].Quality4;

        _copyToClipboard.ProductUrl = clothesInfoList[0].URL;
        //URLTextField.text = clothesInfoList[0].URL;

        Debug.Log("ShowData - QRCode3 End");
    }

    public void CallDatabaseQRCode4()
    {
        DB = GameObject.Find("DatabaseHandler").GetComponent<Database>();
        List<Cloth> clothesInfoList;
        clothesInfoList = DB.GetclothesInfoListQRCode4();

        nameTextField = GameObject.Find("QRCode4_Name").GetComponent<Text>();
        nameTextField.text = clothesInfoList[0].Name;

        PriceTextField = GameObject.Find("QRCode4_Price").GetComponent<Text>();
        PriceTextField.text = clothesInfoList[0].Price;

        DescriptionTextField = GameObject.Find("QRCode4_Description").GetComponent<Text>();
        DescriptionTextField.text = clothesInfoList[0].Description;

        QualityTextField = GameObject.Find("QRCode4_Quality").GetComponent<Text>();
        QualityTextField.text = clothesInfoList[0].Quality;

        Quality2TextField = GameObject.Find("QRCode4_Quality2").GetComponent<Text>();
        Quality2TextField.text = clothesInfoList[0].Quality2;

        Quality3TextField = GameObject.Find("QRCode4_Quality3").GetComponent<Text>();
        Quality3TextField.text = clothesInfoList[0].Quality3;

        Quality4TextField = GameObject.Find("QRCode4_Quality4").GetComponent<Text>();
        Quality4TextField.text = clothesInfoList[0].Quality4;

        _copyToClipboard.ProductUrl = clothesInfoList[0].URL;
        //URLTextField.text = clothesInfoList[0].URL;

        Debug.Log("ShowData - QRCode4 End");
    }
}

