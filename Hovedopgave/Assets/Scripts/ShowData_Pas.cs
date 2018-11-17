using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowData_Pas : MonoBehaviour
{
    // Mikael Paaske
    public Text nameTextField;
    public Text PriceTextField;
    public Text DescriptionTextField;
    public Text QualityTextField;
    public Text Quality2TextField;
    //public Text URLTextField;
    private Database_Pas DB;
    // Use this for initialization
    void Start()
    {
        Debug.Log("ShowData - Start");
        


        List<Cloth> clothlist;
        clothlist = DB.GetClothList();

        nameTextField.text = clothlist[0].Name;
        PriceTextField.text = clothlist[0].Price;
        DescriptionTextField.text = clothlist[0].Description;
        QualityTextField.text = clothlist[0].Quality;
        Quality2TextField.text = clothlist[0].Quality2;
        //URLTextField.text = clothlist[0].URL;
        Debug.Log("ShowData - End");
    }
    void CallDatabase() {
        {
            DB = GameObject.Find("DatabaseHandler").GetComponent<Database_Pas>(); // Denne der skal kaldes før at tekstfelter bliver "låst op". 
        }
    }
}
