using UnityEngine;
using UnityEngine.EventSystems;

public class DisplayProduct : MonoBehaviour
{
    // Mikael Paaske og Thomas Nielsen
    private GameObject modelPlaceHolder;

    public void Start()
    {
        // Henter bool fra SettingsScript og checker om den er sand er falsk
        if (SettingsScript.isMale)
        {
            // Instansiere den nøgne mandlige model på graderne 0,180,0
            modelPlaceHolder = Resources.Load<GameObject>("Prefabs/MaleNaked");
            Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
        }
        else if (!SettingsScript.isMale)
        {
            // Instansiere den nøgne kvindlige model på graderne 0,180,0
            modelPlaceHolder = Resources.Load<GameObject>("Prefabs/FemaleNaked");
            Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
        }
    }

    public void ChangeCloth()
    {
        DestroyAll();
        CheckNameAndSpawn();
    }

    public void CheckNameAndSpawn()
    {
        // Checker navnet på knappen der er trykket på
        if (EventSystem.current.currentSelectedGameObject.name == "MaleBlackJacket")
            // Hvis modellen allerede findes i scenen, hentes den nøgne model, hvis ikke bliver modellen vist.
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

        if (EventSystem.current.currentSelectedGameObject.name == "MalePantsBlue")
            if (GameObject.Find("MalePantsBlue(Clone)"))
            {
                modelPlaceHolder = Resources.Load<GameObject>("Prefabs/MaleNaked");
                Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
            }
            else
            {
                modelPlaceHolder = Resources.Load<GameObject>("Prefabs/MalePantsBlue");
                Instantiate(modelPlaceHolder, Vector3.zero, Quaternion.Euler(0, 180, 0));
            }

        if (EventSystem.current.currentSelectedGameObject.name == "MaleTShirtWhite")
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

        if (EventSystem.current.currentSelectedGameObject.name == "MaleUnderPantsBlack")
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

        if (EventSystem.current.currentSelectedGameObject.name == "FemaleBlackShoes")
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

        if (EventSystem.current.currentSelectedGameObject.name == "FemaleBlackUnderPants")
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

        if (EventSystem.current.currentSelectedGameObject.name == "FemaleBlueDress")
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

        if (EventSystem.current.currentSelectedGameObject.name == "FemaleGreenJacket")
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