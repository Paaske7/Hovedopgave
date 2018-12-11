using UnityEngine;
using UnityEngine.EventSystems;

public class DisplayProduct : MonoBehaviour
{
    // Mikael Paaske og Thomas Nielsen
    private GameObject modelPlaceHolder;
    private GameObject parentPanel;

    public void Start()
    {
        // Henter bool fra SettingsScript og checker om den er sand er falsk
        if (SettingsScript.isMale)
        {
            // Instansiere den nøgne mandlige model på graderne 0,180,0
            modelPlaceHolder = Resources.Load<GameObject>("Prefabs/MaleNaked");
            Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
        }
        else
        {
            // Instansiere den nøgne kvindlige model på graderne 0,180,0
            modelPlaceHolder = Resources.Load<GameObject>("Prefabs/FemaleNaked");
            Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
        }
    }

    public void ChangeCurrentProduct()
    {
        //Fjern alle produkter fra scenen
        DestroyAll();

        if (SettingsScript.isMale)
        {
            parentPanel = GameObject.Find("MaleProducts");
            //Hvis det er det første knap (product_1) der trykkes
            if (EventSystem.current.currentSelectedGameObject.name == "Product_1")
            {
                //Hvis produktet allerede er i scenen
                if (GameObject.Find("MalePantsBlue(Clone)"))
                {
                    modelPlaceHolder = Resources.Load<GameObject>("Prefabs/MaleNaked");
                    Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
                }
                else
                {
                    //spawn produktet
                    modelPlaceHolder = Resources.Load<GameObject>("Prefabs/MalePantsBlue");
                    Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
                }
                //skjul produktkataloget
                parentPanel.SetActive(false);
            }
            //gentages for hver male og female produkt

            if (EventSystem.current.currentSelectedGameObject.name == "Product_2")
            {
                if (GameObject.Find("MaleBlackJacket(Clone)"))
                {
                    modelPlaceHolder = Resources.Load<GameObject>("Prefabs/MaleNaked");
                    Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
                }
                else
                {
                    modelPlaceHolder = Resources.Load<GameObject>("Prefabs/MaleBlackJacket");
                    Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
                }

                parentPanel.SetActive(false);
            }

            if (EventSystem.current.currentSelectedGameObject.name == "Product_3")
            {
                if (GameObject.Find("MaleUnderPantsBlack(Clone)"))
                {
                    modelPlaceHolder = Resources.Load<GameObject>("Prefabs/MaleNaked");
                    Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
                }
                else
                {
                    modelPlaceHolder = Resources.Load<GameObject>("Prefabs/MaleUnderPantsBlack");
                    Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
                }

                parentPanel.SetActive(false);
            }

            if (EventSystem.current.currentSelectedGameObject.name == "Product_4")
            {
                if (GameObject.Find("MaleTShirtWhite(Clone)"))
                {
                    modelPlaceHolder = Resources.Load<GameObject>("Prefabs/MaleNaked");
                    Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
                }
                else
                {
                    modelPlaceHolder = Resources.Load<GameObject>("Prefabs/MaleTShirtWhite");
                    Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
                }

                parentPanel.SetActive(false);
            }
        }
        else
        {
            parentPanel = GameObject.Find("FemaleProducts");
            if (EventSystem.current.currentSelectedGameObject.name == "Product_1")
            {
                if (GameObject.Find("FemaleBlackShoes(Clone)"))
                {
                    modelPlaceHolder = Resources.Load<GameObject>("Prefabs/FemaleNaked");
                    Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
                }
                else
                {
                    modelPlaceHolder = Resources.Load<GameObject>("Prefabs/FemaleBlackShoes");
                    Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
                }

                parentPanel.SetActive(false);
            }
            else if (EventSystem.current.currentSelectedGameObject.name == "Product_2")
            {
                if (GameObject.Find("FemaleGreenJacket(Clone)"))
                {
                    modelPlaceHolder = Resources.Load<GameObject>("Prefabs/FemaleNaked");
                    Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
                }
                else
                {
                    modelPlaceHolder = Resources.Load<GameObject>("Prefabs/FemaleGreenJacket");
                    Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
                }

                parentPanel.SetActive(false);
            }
            else if (EventSystem.current.currentSelectedGameObject.name == "Product_3")
            {
                if (GameObject.Find("FemaleBlackUnderPants(Clone)"))
                {
                    modelPlaceHolder = Resources.Load<GameObject>("Prefabs/FemaleNaked");
                    Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
                }
                else
                {
                    modelPlaceHolder = Resources.Load<GameObject>("Prefabs/FemaleBlackUnderPants");
                    Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
                }

                parentPanel.SetActive(false);
            }
            else if (EventSystem.current.currentSelectedGameObject.name == "Product_4")
            {
                if (GameObject.Find("FemaleBlueDress(Clone)"))
                {
                    modelPlaceHolder = Resources.Load<GameObject>("Prefabs/FemaleNaked");
                    Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
                }
                else
                {
                    modelPlaceHolder = Resources.Load<GameObject>("Prefabs/FemaleBlueDress");
                    Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
                }

                parentPanel.SetActive(false);
            }
        }
    }

    public void DestroyAll()
    {
        // Sletter alle modeller i scenen
        foreach (var Obj in Resources.FindObjectsOfTypeAll<GameObject>())
            if (Obj.name == "FemaleNaked(Clone)" || Obj.name == "FemaleBlackShoes(Clone)" ||
                Obj.name == "FemaleBlackUnderPants(Clone)" ||
                Obj.name == "FemaleBlueDress(Clone)" || Obj.name == "FemaleGreenJacket(Clone)" ||
                Obj.name == "MaleBlackJacket(Clone)" || Obj.name == "MaleNaked(Clone)"
                || Obj.name == "MalePantsBlue(Clone)" || Obj.name == "MaleTShirtWhite(Clone)" ||
                Obj.name == "MaleUnderPantsBlack(Clone)")
                Destroy(Obj);
    }
}