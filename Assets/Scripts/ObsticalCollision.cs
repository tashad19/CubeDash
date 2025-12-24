
using UnityEngine;

public class ObsticalCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "mane")
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
