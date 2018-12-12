using UnityEngine;

public class ProductUrlHandler : MonoBehaviour
{
    //Thomas Nielsen
    [HideInInspector] public string ProductUrl;

    public void CopyUrlToClipboard()
    {
        Debug.Log("ProductUrlHandler URL: " + ProductUrl);
        //Send produktets URL til enhedens udklipsholder 
        UniClipboard.SetText(ProductUrl);
        //Load popup vindue prefab
        GameObject popupWindow = Resources.Load<GameObject>("Prefabs/PopupWindow");
        //instansier i scenen og brug prefabets gemte position
        GameObject tempWindow = Instantiate(popupWindow, popupWindow.transform.position, Quaternion.identity) as GameObject;
        //Find canvas fra ARcamera og sæt popupvinduet som child - popup vinduet vises ikke hvis det ikke er i et canvas
        tempWindow.transform.SetParent(GameObject.Find("MenuCanvas").transform, false);

        //Fjern popupvinduet fra scenen efter 3 sekunder
        Destroy(tempWindow, 3f);         //erstat med fade som i starterscenescript

        //Åbner URL fra produktet
        if (SettingsScript.openInApp == false)
        {
            Application.OpenURL(ProductUrl);
        }
        else if (SettingsScript.openInApp == true)
        {
            GameObject popupWindow2 = Resources.Load<GameObject>("Prefabs/PopupWindow2");
            //instansier i scenen og brug prefabets gemte position
            GameObject tempWindow2 = Instantiate(popupWindow2, popupWindow2.transform.position, Quaternion.identity) as GameObject;
            //Find canvas fra ARcamera og sæt popupvinduet som child - popup vinduet vises ikke hvis det ikke er i et canvas
            tempWindow2.transform.SetParent(GameObject.Find("MenuCanvas").transform, false);
            Destroy(tempWindow2, 3f);
        }
    }
    public void OpenProductUrl()
    {   
            Application.OpenURL(ProductUrl);
    }
}
