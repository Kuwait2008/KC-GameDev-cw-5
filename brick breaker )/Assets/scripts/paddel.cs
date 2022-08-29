using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddel : MonoBehaviour
{
    public Rigidbody2D RB;
    
    float playerinput;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        

    }
    private void FixedUpdate()
    {
        move();
    }

    void move()
    {
        playerinput = Input.GetAxis("Horizontal");
        RB.velocity = new Vector2(playerinput * speed , 0);
    }
        

 
}
