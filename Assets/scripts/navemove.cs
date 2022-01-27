using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navemove : MonoBehaviour
{
    public float MoveVelocityNave;
    public float JumpForce;
    public float DownForce;

    private Rigidbody2D Rigidbody2D; 
    public float Horizontal;

    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        if (Horizontal < 0.0f) transform.localScale = new Vector3(0.5f, -0.5f, 0.5f);
        else if (Horizontal > 0.0f) transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);


        if (Input.GetKey(KeyCode.W))
        {
            Jump();
        }
        if (Input.GetKey(KeyCode.S))
        {
            Down();
        }

    }

    private void Jump()
    {
        Rigidbody2D.AddForce(Vector2.up * JumpForce);
    }
    private void Down()
    {
        Rigidbody2D.AddForce(Vector2.up * JumpForce * -1);
    }

    private void FixedUpdate(){
        Horizontal = 1;
        Rigidbody2D.velocity = new Vector2(Horizontal * MoveVelocityNave, Rigidbody2D.velocity.y);
    }

}
