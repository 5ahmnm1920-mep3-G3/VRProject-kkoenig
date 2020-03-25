using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    Text txt;
    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<Text>();
        txt.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreScript.scoreValue >= 50)
        {
           txt.text = "CONGRATULATION! YOU SAVED THE WORLD";
           txt.enabled = true;
        }

        else if (ScoreScript.scoreValue < 0)
        {
            txt.text = "YOU LOST! DON'T LITTER NATURE";
            txt.enabled = true;
        }
    }
}
