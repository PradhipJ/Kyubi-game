using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardFloat = 2000f;
    public float sidewardForce = 500f;
    public float backwardForce = -400f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardFloat* Time.deltaTime);
        if(Input.GetKey("d")){
            rb.AddForce(sidewardForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        else if(Input.GetKey("a")){
            rb.AddForce((-1)*sidewardForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }
    
    }
}
