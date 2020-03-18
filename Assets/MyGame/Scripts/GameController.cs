using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    void OnTriggerEnter(Collider theCollision) // C#, type first, name in second
    {
        if (theCollision.gameObject.tag == "Trash")
        // By using {}, the condition apply to that entire scope, instead of the next line.
        {
            Debug.Log("trash");
        }

        else if (theCollision.gameObject.tag == "Nature")
        {
            Debug.Log("nature");
        }
    }
}
