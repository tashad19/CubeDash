
using UnityEngine;

public class collision : MonoBehaviour
{
    public PlayerMovement movement;
    // Start is called before the first frame update
     void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag=="mane")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
