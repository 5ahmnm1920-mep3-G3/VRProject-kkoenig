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
            Debug.Log("trash");
            ScoreScript.scoreValue += 10;
            Trashcan.GetComponent<Renderer>().material.color = new Color(0.438f, 0.632f, 0.444f);
            StartCoroutine(ResetColorTrashcan());
            Destroy(theCollision.gameObject);

        }

        else
        {
            Debug.Log("nature");
            ScoreScript.scoreValue -= 10;
            Trashcan.GetComponent<Renderer>().material.color = new Color(0.679f, 0.328f, 0.323f);
            StartCoroutine(ResetColorTrashcan());
            Destroy(theCollision.gameObject);
        }
    }
    public IEnumerator ResetColorTrashcan()
    {
        yield return new WaitForSeconds(0.8f);
        var trashRenderer = Trashcan.GetComponent<Renderer>();
        trashRenderer.material.SetColor("_Color", Color.grey);
    }
}
