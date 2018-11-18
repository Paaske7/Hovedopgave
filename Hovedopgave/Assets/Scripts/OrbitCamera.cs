using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCamera : MonoBehaviour
{

    public GameObject target;

    public float smoothSpeed = 0.125f;

    public Vector3 offSet;
    public float rotateSpeed;


    private float speedMod = 10.0f;//a speed modifier
    private Vector3 point;//the coord to the point where the camera looks at
    private void FixedUpdate()
    {

        if (Input.GetMouseButton(1) == true)
        {
            //Set up things on the start method
            point = target.transform.position;//get target's coords
            transform.LookAt(point);//makes the camera look to it
                                    //makes the camera rotate around "point" coords, rotating around its Y axis, 4 degrees per second times the speed modifier
            transform.RotateAround(point, new Vector3(0.0f, 1.0f, 0.0f), 10 * Time.deltaTime * speedMod);
            Debug.Log("mouse down");
        }
        else
        {
            //Follow Player
            Vector3 desiredPosition = target.transform.position + offSet;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
            transform.LookAt(target.transform);
        }
    }
}
//public GameObject target;//the target object
//    private float speedMod = 10.0f;//a speed modifier
//    private Vector3 point;//the coord to the point where the camera looks at

//    void Start()
//    {//Set up things on the start method
//        point = target.transform.position;//get target's coords
//        transform.LookAt(point);//makes the camera look to it
//    }

//    void Update()
//    {//makes the camera rotate around "point" coords, rotating around its Y axis, 20 degrees per second times the speed modifier
//        transform.RotateAround(target.transform.position, Vector3.up, speedMod * Time.deltaTime);
//    }


//}