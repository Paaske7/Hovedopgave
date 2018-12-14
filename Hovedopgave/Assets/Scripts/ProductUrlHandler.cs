using UnityEngine;
using UnityEngine.UI;

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

        //Sætter popuptekst alt efter om indstillingerne er sat til at åbne app eller hjemmeside
        popupWindow.GetComponentInChildren<Text>(true).text = SettingsScript.openInApp ? "Link kopieret til udklipsholder - Åbner Ønskeskyens app..." : "Link kopieret til udklipsholder - Åbner Ønskeskyens hjemmeside...";
        //instansier i scenen og brug prefabets gemte position
        GameObject tempWindow = Instantiate(popupWindow, popupWindow.transform.position, Quaternion.identity) as GameObject;
        //Find canvas fra ARcamera og sæt popupvinduet som child - popup vinduet vises ikke hvis det ikke er i et canvas
        tempWindow.transform.SetParent(GameObject.Find("MenuCanvas").transform, false);

        //Fjern popupvinduet fra scenen efter 3 sekunder
        Destroy(tempWindow, 3f);         //erstat med fade som i starterscenescript

        if (SettingsScript.openInApp == false)
        {
            //Åbner Ønskeskyens hjemmeside
            Application.OpenURL("https://ønskeskyen.dk/");
        }
        else if (SettingsScript.openInApp == true)
        {
            //GameObject popupWindow2 = Resources.Load<GameObject>("Prefabs/PopupWindow2");
            ////instansier i scenen og brug prefabets gemte position
            //GameObject tempWindow2 = Instantiate(popupWindow2, popupWindow2.transform.position, Quaternion.identity) as GameObject;
            ////Find canvas fra ARcamera og sæt popupvinduet som child - popup vinduet vises ikke hvis det ikke er i et canvas
            //tempWindow2.transform.SetParent(GameObject.Find("MenuCanvas").transform, false);
            //Destroy(tempWindow2, 3f);

            //Åbner Ønskeskyens app, hvis det ikke installeres åbnes deres side på Google Play Store
            OpenAnotherAndroidApp();
        }
    }
    public void OpenProductUrl()
    {
        //Åbner URL fra produktet
        Application.OpenURL(ProductUrl);
    }

    private void OpenAnotherAndroidApp()
    {
        bool fail = false;
        string bundleId = "com.ovdal.onskeskyen"; // your target bundle id
        AndroidJavaClass up = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject ca = up.GetStatic<AndroidJavaObject>("currentActivity");
        AndroidJavaObject packageManager = ca.Call<AndroidJavaObject>("getPackageManager");

        AndroidJavaObject launchIntent = null;
        try
        {
            launchIntent = packageManager.Call<AndroidJavaObject>("getLaunchIntentForPackage", bundleId);
            ca.Call("startActivity", launchIntent);
        }
        catch (System.Exception)
        {
            Application.OpenURL("https://play.google.com/store/apps/details?id=com.ovdal.onskeskyen&hl=da");
        }

        if (fail)
        { //open app in store
            
        }
        else //open the app
            

        up.Dispose();
        ca.Dispose();
        packageManager.Dispose();
        launchIntent.Dispose();
    }
}
