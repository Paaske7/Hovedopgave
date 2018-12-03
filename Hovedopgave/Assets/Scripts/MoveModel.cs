using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveModel : MonoBehaviour {

    // Mikael Paaske
    private GameObject model;
    private GameObject model2;
    float speed = 6.0f;

    public void MoveLeft()
    {
        if (GameObject.Find("xbot(Clone)") != null)
        {
            model = GameObject.Find("xbot(Clone)");
            model.transform.Rotate(Vector3.up * speed);
        }

        if (GameObject.Find("ybot(Clone)") != null)
        {
            model2 = GameObject.Find("ybot(Clone)");
            model2.transform.Rotate(Vector3.up * speed);
        }
    }

    public void MoveRight()
    {
        if (GameObject.Find("xbot(Clone)") != null)
        {
            model = GameObject.Find("xbot(Clone)");
            model.transform.Rotate(Vector3.down * speed);
        }
        if (GameObject.Find("ybot(Clone)") != null)
        {
            model2 = GameObject.Find("ybot(Clone)");
            model2.transform.Rotate(Vector3.down * speed);
        }
    }
}
