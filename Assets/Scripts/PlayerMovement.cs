using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forward = 2000f;
    public float sideward = 500f;
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forward * Time.deltaTime);

        

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideward * Time.deltaTime, 0, 0,ForceMode.VelocityChange);

        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideward * Time.deltaTime, 0, 0,ForceMode.VelocityChange);

        }
        if(rb.position.y<-1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }


    }
}
