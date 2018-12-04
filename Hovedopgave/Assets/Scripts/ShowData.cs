using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{
    // Mikael Paaske
    public Text nameTextField;
    public Text PriceTextField;
    public Text DescriptionTextField;
    public Text QualityTextField;
    public Text Quality2TextField;
    //public Text URLTextField;
    private Database DB;
    private GameObject GameController;
  
    public void CallDatabasePas()
    {
        {
            DB = GameObject.Find("DatabaseHandler").GetComponent<Database>();
            List<Cloth> clothlist;
            clothlist = DB.GetClothListPas();
            GameController = GameObject.Find("GameController");

            nameTextField = GameObject.Find("Pas_Name").GetComponent<Text>();
            nameTextField.text = clothlist[0].Name;

            PriceTextField = GameObject.Find("Pas_Price").GetComponent<Text>();
            PriceTextField.text = clothlist[0].Price;

            DescriptionTextField = GameObject.Find("Pas_Description").GetComponent<Text>();
            DescriptionTextField.text = clothlist[0].Description;

            QualityTextField = GameObject.Find("Pas_Quality").GetComponent<Text>();
            QualityTextField.text = clothlist[0].Quality;

            Quality2TextField = GameObject.Find("Pas_Quality2").GetComponent<Text>();
            Quality2TextField.text = clothlist[0].Quality2;

            //URLTextField.text = clothlist[0].URL;
            GameController.GetComponent<copypaste>().ProductUrl = clothlist[0].URL;
            Debug.Log("Product URL SD: " + clothlist[0].URL);

            Debug.Log("ShowData - End");
        }
    }
    public void CallDatabase6OfSpades()
    {
        DB = GameObject.Find("DatabaseHandler").GetComponent<Database>();
        List<Cloth> clothlist;
        clothlist = DB.GetClothList6OfSpades();
        GameController = GameObject.Find("GameController");

        nameTextField = GameObject.Find("6OfSpades_Name").GetComponent<Text>();
        nameTextField.text = clothlist[0].Name;

        PriceTextField = GameObject.Find("6OfSpades_Price").GetComponent<Text>();
        PriceTextField.text = clothlist[0].Price;

        DescriptionTextField = GameObject.Find("6OfSpades_Description").GetComponent<Text>();
        DescriptionTextField.text = clothlist[0].Description;

        QualityTextField = GameObject.Find("6OfSpades_Quality").GetComponent<Text>();
        QualityTextField.text = clothlist[0].Quality;

        Quality2TextField = GameObject.Find("6OfSpades_Quality2").GetComponent<Text>();
        Quality2TextField.text = clothlist[0].Quality2;
        
        //URLTextField.text = clothlist[0].URL;
        GameController.GetComponent<copypaste>().ProductUrl = clothlist[0].URL;
        Debug.Log("Product URL SD: " + clothlist[0].URL);
    }
}

