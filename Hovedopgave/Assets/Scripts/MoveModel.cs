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
        if (GameObject.Find("m01_naked_00_h(Clone)") != null)
        {
            model = GameObject.Find("m01_naked_00_h(Clone)");
            model.transform.Rotate(Vector3.up * speed);
        }

        if (GameObject.Find("m01_schoolwear_000_h(Clone)") != null)
        {
            model2 = GameObject.Find("m01_schoolwear_000_h(Clone)");
            model2.transform.Rotate(Vector3.up * speed);
        }
    }

    public void MoveRight()
    {
        if (GameObject.Find("m01_naked_00_h(Clone)") != null)
        {
            model = GameObject.Find("m01_naked_00_h(Clone)");
            model.transform.Rotate(Vector3.down * speed);
        }
        if (GameObject.Find("m01_schoolwear_000_h(Clone)") != null)
        {
            model2 = GameObject.Find("m01_schoolwear_000_h(Clone)");
            model2.transform.Rotate(Vector3.down * speed);
        }
    }
}
