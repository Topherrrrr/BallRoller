using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHoopControl : MonoBehaviour
{
    bool left, right;
    public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        rotateSpeed = BallControl.rotateSpeed;
        #region RotateControls
        if (Input.GetKeyDown("a"))
        {
            left = true;
            right = false;
        }
        else if(Input.GetKeyDown("d"))
        {
            right = true;
            left = false;
        }

        if(right)
        {
            transform.Rotate(new Vector3(0, rotateSpeed, 0));
        }
        else if(left)
        {
            transform.Rotate(new Vector3(0, -rotateSpeed, 0));
        }

        if(Input.GetKeyUp("a"))
        {
            left = false;
        }
        else if(Input.GetKeyUp("d"))
        {
            right = false;
        }
        #endregion
        transform.position = Basics.Player.transform.position + new Vector3(0, 5, 0);
    }
}
