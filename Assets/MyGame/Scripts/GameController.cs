using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    GameObject Trashcan;

    void OnTriggerEnter(Collider theCollision)
    {
        if (theCollision.gameObject.tag == "Trash")
        {
            ScoreScript.scoreValue += 10;
            Debug.Log("trash");
            Destroy(theCollision.gameObject);
        }
        else
        {
            ScoreScript.scoreValue -= 10;
            Debug.Log("Nature");
            Destroy(theCollision.gameObject);
        }
    }
}
