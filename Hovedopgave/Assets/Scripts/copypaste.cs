using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class copypaste : MonoBehaviour {
    public string ProductUrl;

    public void CopyPaste()
    {
        Debug.Log("Product URL CP: " + ProductUrl);
        UniClipboard.SetText(ProductUrl);


        GameObject parentCanvas = GameObject.Find("6OfSpades_Canvas");

        GameObject popupWindow = Resources.Load<GameObject>("Prefabs/PopupWindow");
        GameObject tempWindow = Instantiate(popupWindow, popupWindow.transform.position, Quaternion.identity) as GameObject;
        // tempWindow.transform.parent = parentCanvas.transform;
        tempWindow.transform.SetParent(GameObject.Find("6OfSpades_Canvas").transform, false);

        Destroy(tempWindow,3f);
    }
}
