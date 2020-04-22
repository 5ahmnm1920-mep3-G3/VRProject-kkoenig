using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject Trashcan;
    [SerializeField] private AudioSource audioSrc;
    [SerializeField] private AudioClip positiveSound;
    [SerializeField] private AudioClip negativeSound;

    void OnTriggerEnter(Collider theCollision)
    {
        if (theCollision.gameObject.tag == "Trash")
        {
            Debug.Log("trash");
            ScoreScript.scoreValue += 10;
            Trashcan.GetComponent<Renderer>().material.color = new Color(0.438f, 0.632f, 0.444f);
            StartCoroutine(ResetColorTrashcan());
            Destroy(theCollision.gameObject);
            audioSrc.PlayOneShot(positiveSound, 0.5f);

        }

        else
        {
            Debug.Log("nature");
            ScoreScript.scoreValue -= 10;
            Trashcan.GetComponent<Renderer>().material.color = new Color(0.679f, 0.328f, 0.323f);
            StartCoroutine(ResetColorTrashcan());
            Destroy(theCollision.gameObject);
            audioSrc.PlayOneShot(negativeSound, 1f);
        }
    }
    public IEnumerator ResetColorTrashcan()
    {
        yield return new WaitForSeconds(0.8f);
        var trashRenderer = Trashcan.GetComponent<Renderer>();
        trashRenderer.material.SetColor("_Color", Color.grey);
    }
}
