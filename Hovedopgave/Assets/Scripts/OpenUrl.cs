using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrl : MonoBehaviour {

    public void OpenURL()
    {
        Application.OpenURL("https://www2.hm.com/da_dk/productpage.0569984016.html/");
        Debug.Log("is this working?");
    }
}

