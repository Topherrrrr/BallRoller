using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlocks : MonoBehaviour
{
    public float intervalStart, interval;
    
    //How fast the block moves back and forth
    public float moveSpeed = .1f;
    // Start is called before the first frame update
    void Start()
    {
        interval = intervalStart;
    }

    // Update is called once per frame
    void Update()
    {
        if(interval >0)
        {
            transform.Translate(moveSpeed, 0, 0);
            interval--;
        }
        else if(interval <=0)
        {
            moveSpeed *= -1;
            interval = intervalStart;
        }
    }
}
