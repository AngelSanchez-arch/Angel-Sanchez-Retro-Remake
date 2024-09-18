using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentPM : MonoBehaviour
{
    public KeyCode left = KeyCode.A, right = KeyCode.D, up = KeyCode.W, down = KeyCode.S; //jump = KeyCode.w
    public float speed = 10, jumpHeight = 15;
   
    private Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Input.GetKey() is for holding a key
        // Input.GetKeyDown() is for pressing a key 
        // Input.GetKeyup() is for releasing a key 

        if (Input.GetKey(left)) //Check for player holding down left button
        {
            // Get the GameObject's rigidbody2d component and set its velocity to the left at the given speed
            _rb.velocity = Vector2.left * speed;
        }
        if (Input.GetKey(right)) //Check for player holding down right button
        {
            // Get the GameObject's rigidbody2d component and set its velocity to the left at the given speed
            _rb.velocity = Vector2.right * speed;
        }

        if (Input.GetKey(up)) //Check for player holding down up button
        {
            // Get the GameObject's rigidbody2d component and set its velocity to the left at the given speed
            _rb.velocity = Vector2.up * speed;
        }
        if (Input.GetKey(down)) //Check for player holding down button
        {
            // Get the GameObject's rigidbody2d component and set its velocity to the left at the given speed
            _rb.velocity = Vector2.down * speed;
        }

        //if (Input.GetKeyDown(jump))
        {
            //_rb.velocity = Vector2.up * jumpHeight;
        }
    }
}
