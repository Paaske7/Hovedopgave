using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ProductUrlHandler : MonoBehaviour {
    //Thomas Nielsen
    public string ProductUrl;

    public void CopyUrlToClipboard()
    {
        Debug.Log("Product URL CP: " + ProductUrl);
        //Send produktets URL til enhedens udklipsholder 
        UniClipboard.SetText(ProductUrl);

        //Load popup vindue prefab
        GameObject popupWindow = Resources.Load<GameObject>("Prefabs/PopupWindow");
        //instansier i scenen og brug prefabets gemte position
        GameObject tempWindow = Instantiate(popupWindow, popupWindow.transform.position, Quaternion.identity) as GameObject;

        //Find canvas fra ARcamera og sæt popupvinduet som child - popup vinduet vises ikke hvis det ikke er i et canvas
        GameObject parentCanvas = GameObject.Find("Canvas");
        //tempWindow.transform.parent = parentCanvas.transform;
        tempWindow.transform.SetParent(GameObject.Find("Canvas").transform, false);
     
        //Fjern popupvinduet fra scenen efter 3 sekunder
        Destroy(tempWindow,3f);
    }
    public void OpenURL()
    {
        Application.OpenURL(ProductUrl);
    }
}
