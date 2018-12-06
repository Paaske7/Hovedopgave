using UnityEngine;

public class MoveModel : MonoBehaviour {

    // Mikael Paaske
    float speed = 6.0f;
    public GameObject[] respawns;

    public void Start()
    {
       
    }
    public void MoveLeft()
    {
        if (respawns != null)
        { 
            respawns = GameObject.FindGameObjectsWithTag("Respawn");

            respawns[0].transform.Rotate(Vector3.up * speed);
        }
    }

    public void MoveRight()
    {
        if (respawns != null)
        {
            respawns = GameObject.FindGameObjectsWithTag("Respawn");

            respawns[0].transform.Rotate(Vector3.down * speed);
        }
    }
}
