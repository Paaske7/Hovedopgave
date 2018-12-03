using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class DisplayProduct : MonoBehaviour
{
    public GameObject productPlaceHolder;

    public void SwitchProduct(GameObject selectedButton)
    {
        // Thomas Nielsen
        //lav toggle på on/off for at fjerne et produkt hvis det allerede vises
        string ProductName = selectedButton.GetComponentInChildren<Text>().text;


        if (GameObject.Find(ProductName + "(Clone)") != null)
        {
            productPlaceHolder = GameObject.Find(ProductName + "(Clone)");
            Destroy(productPlaceHolder);
        }
        else
        {
            productPlaceHolder = Resources.Load<GameObject>("Prefabs/Products/" + ProductName);
            Instantiate(productPlaceHolder, productPlaceHolder.transform.position, Quaternion.Euler(0, 180, 0)); // instatiate a prefab on the position where the ray hits the floor.
        }

        Debug.Log("slut: " + productPlaceHolder.name);
    }
}
