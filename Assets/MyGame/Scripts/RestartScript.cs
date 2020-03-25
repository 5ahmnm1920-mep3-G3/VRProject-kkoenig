using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartScript : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
    }
}
