
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float 1f;

    public void EndGame()
    {
        if (gameHasEnded = false)
        {

        }
        gameHasEnded = true;
        Debug.Log("Game Over");
        Invoke("Restart", delay);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
