using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Player : MonoBehaviour
{
    public float speed;
    public int jumpForce;
    public Rigidbody rb; 

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0, 0);
        }
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, jumpForce, 0);
        }

    }
}
