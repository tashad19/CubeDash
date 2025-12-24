using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool game = false;
    public float RestartDelay = 2f;
    public GameObject complete;

    // Start is called before the first frame update
    public void GameOver()
    {
        if(game == false)
        {
            Debug.Log("Game Over!");
            game = true;
            Invoke("Restart", RestartDelay);
         
        }
      
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void completeLevel()
    {
        complete.SetActive(true);
    }
}
