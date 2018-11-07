using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{

    public Text nameTextField;
    private Database DB;
    // Use this for initialization
    void Start()
    {
        DB = GameObject.Find("DatabaseHandler").GetComponent<Database>();


        List<Cloth> clothlist;
        clothlist = DB.GetClothList();

        nameTextField.text = clothlist[0].Name;
    }
}
