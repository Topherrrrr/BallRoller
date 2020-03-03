using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicBlock : MonoBehaviour
{
    public float speed;
    public bool moving;
    public Vector3 targetPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(moving)
        {
            print("Moving");
            StartCinematic(targetPoint);
        }
    }

    void StartCinematic(Vector3 destination)
    {
        if((gameObject.transform.position.x-destination.x)<.1 && (gameObject.transform.position.x - destination.x) > -.1)
        {
        //    moving = false;
        }
        else if(gameObject.transform.position.x>destination.x)
        {
            transform.Translate(-speed, 0, 0);
        }
        else if(gameObject.transform.position.x<destination.x)
        {
            transform.Translate(speed, 0, 0);
        }

        if ((gameObject.transform.position.y - destination.y) < .1 && (gameObject.transform.position.y - destination.y) > -.1)
        {
          //  moving = false;

        }
        else if (gameObject.transform.position.y > destination.y)
        {
          //  transform.Translate(0, -speed, 0);
        }
        else if (gameObject.transform.position.y < destination.y)
        {
            transform.Translate(0, speed, 0);
        }

        if ((gameObject.transform.position.z - destination.z) < .1 && (gameObject.transform.position.z - destination.z) > -.1)
        {
          //  moving = false;

        }
        else if (gameObject.transform.position.z > destination.z)
        {
            transform.Translate(0, 0, -speed);
        }
        else if (gameObject.transform.position.z < destination.z)
        {
            transform.Translate(0, 0, speed);
        }
    }
}
