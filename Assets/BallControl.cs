using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    //Directions for momentum (forward & back)
    float forwardMomentum, backwardMomentum;
    //The force of the momentum when it's first applied
    float startMomentum = .1f;

    //Directions for which direction the player is moving
    public bool left, right, forward, backward;

    //Rigidbody attached to the player
   Rigidbody rb;

    //How fast the player moves
    public float speed;

    //How fast the player rotates
    public float RotateSpeed;
    public static float rotateSpeed;

    //How much force to apply for jumps
    float jumpForce = 200f;

    //Is the ball on the ground
    bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        //Assigning forward & backward momentum to have the starting speed
        forwardMomentum = startMomentum;
        backwardMomentum = startMomentum;
        rotateSpeed = RotateSpeed;
        rb = gameObject.GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        #region momentum

        //If momentum is zero, move the player and tick down until it reaches zero
        if (forwardMomentum>0)
        {
            forwardMomentum -= startMomentum/200;
            transform.Translate(Vector3.forward * forwardMomentum);
        }
        if(backwardMomentum>0)
        {
            backwardMomentum -= startMomentum/200;
            transform.Translate(Vector3.back * backwardMomentum);
        }
        #endregion

        #region MoveControls
        #region KeyDown
        if(Input.GetKeyDown(KeyCode.Space))
        {
            print("Space pushed");
            if(grounded==true)
            {
                print("Grounded is true");
                rb.AddForce(Vector3.up * jumpForce);
            }
        }
        if (Input.GetKeyDown("a"))
        {
            left = true;
            right = false;
        }
        else if (Input.GetKeyDown("d"))
        {

            right = true;
            left = false;
        }

        if (Input.GetKeyDown("w"))
        {
            forwardMomentum = startMomentum;
            forward = true;
        }
        else if (Input.GetKeyDown("s"))
        {
            backwardMomentum = startMomentum;
            backward = true;
        }
        #endregion

        #region Movement
        if (forward)
        {
            transform.Translate(Vector3.forward * speed);
        }
        else if (backward)
        {
            transform.Translate(Vector3.back * speed);
        }

        if (right)
        {
            transform.Rotate(new Vector3(0, rotateSpeed, 0));
        }
        else if (left)
        {
            transform.Rotate(new Vector3(0, -rotateSpeed, 0));
        }
        #endregion

        #region KeyUp


        if (Input.GetKeyUp("w"))
        {
            forward = false;
        //    rb.AddForce(Vector3.forward * momentumForce);
        }
        else if (Input.GetKeyUp("s"))
        {
            backward = false;
           // rb.AddForce(Vector3.back * momentumForce);
        }
        if (Input.GetKeyUp("a"))
        {
            left = false;
        }
        else if (Input.GetKeyUp("d"))
        {
            right = false;
        }
        #endregion
        #endregion
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag=="Floor")
        {
       //     print("Object is on the ground");
            grounded = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag=="Floor")
        {
            grounded = false;
        }
    }

    private void FixedUpdate()
    {
       
    }
}
