using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float goForward = 1000f;
    public float goRight = -100f;
    public float goLeft = 100f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("PlayerMovement Script is succesfully running.");
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, goForward * Time.deltaTime);

        if(Input.GetButton("left") )
        {
            rb.AddForce(goRight * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetButton("right") )
        {
            rb.AddForce(goLeft * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }   

        if (rb.position.y < -5f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
