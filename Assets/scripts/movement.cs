using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D theRB;
    public float speed;
    public int jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector2(speed * Input.GetAxisRaw("Horizontal"), theRB.velocity.y); jump();
    }
    public void jump () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            theRB.velocity = Vector2.up * jumpForce;
        }
    }
}
