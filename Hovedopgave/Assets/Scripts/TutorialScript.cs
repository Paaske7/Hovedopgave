using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialScript : MonoBehaviour
{
    // Mikael Paaske
    public GameObject toturialText1;

    void Start()
    {
        // Checker om det er første gang appen kører.
        toturialText1 = GameObject.Find("TutorialText1");
        if (PlayerPrefs.GetInt("FIRSTTIMEOPENING", 1) == 1)
        {
            toturialText1.SetActive(true);
            Debug.Log("First Time Opening");

            //Set first time opening to false
            PlayerPrefs.SetInt("FIRSTTIMEOPENING", 0);

        }
        else
        {
            Debug.Log("NOT First Time Opening");
            toturialText1.SetActive(false);
            //Do your stuff here
        }
    }
    // Fjerner kun GameObjekter der har en Box Collider og da det kun er vores Toturial tekster der har dette er et tjek efter navn ikke nødvendig.
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
