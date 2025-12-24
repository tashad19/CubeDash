using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadNextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
