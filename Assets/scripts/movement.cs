using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D theRB;
    public float speed;
    public int jumpForce;
    public bool isGrounded;
    public Switch switch1;
    
    // Start is called before the first frame update
    void Start()
    {
        isGrounded = false;
     
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector2(speed * Input.GetAxisRaw("Horizontal"), theRB.velocity.y); 
        jump();
    }
    public void jump () {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true) {
            theRB.velocity = Vector2.up * jumpForce;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") {
            isGrounded = true;
        }
        if (collision.gameObject.tag == "Switch")
        {
            Destroy(collision.gameObject);
            switch1.switchCount = true;
        }
        if (collision.gameObject.tag == "Switch1")
        {
            Destroy(collision.gameObject);
            switch1.switchOff = true;
        }
    }
}
