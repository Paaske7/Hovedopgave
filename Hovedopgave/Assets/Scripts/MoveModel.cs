﻿using UnityEngine;

public class MoveModel : MonoBehaviour {

    // Mikael Paaske
    float rotation = 45.0f;
    // Opretter et array, hvor alle modeller er inde i.
    public GameObject[] respawns;

    public void MoveLeft()
    {
        if (respawns != null)
        { 
            // Alle modeller er tagget med "Respawn"
            // Finder alle modeller og rykker dem til højre
            respawns = GameObject.FindGameObjectsWithTag("Respawn");

            respawns[0].transform.Rotate(Vector3.up * rotation);
        }
    }

    public void MoveRight()
    {
        if (respawns != null)
        {
            // Alle modeller er tagget med "Respawn"
            // Finder alle modeller og rykker dem til højre
            respawns = GameObject.FindGameObjectsWithTag("Respawn");

            respawns[0].transform.Rotate(Vector3.down * rotation);
        }
    }
}
