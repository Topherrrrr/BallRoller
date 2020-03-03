using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cinematic : MonoBehaviour
{
    public GameObject playerCamera, movieCamera;
    public float frames;
    bool activated = false;
    GameObject target;
    public GameObject targetBlock;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(activated)
        {
            frames--;
            if(frames==0)
            {
                playerCamera.SetActive(true);
                movieCamera.SetActive(false);
                target.GetComponent<BallControl>().enabled = true;
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && activated == false)
        {
            activated = true;
            target = other.gameObject;
            BallControl bc = target.GetComponent<BallControl>();
            bc.left = false;
            bc.right = false;
            bc.forward = false;
            bc.backward = false;
            bc.enabled = false;
            playerCamera.SetActive(false);
            movieCamera.SetActive(true);

            CinematicBlock cb = targetBlock.GetComponent<CinematicBlock>();
            cb.moving = true;
        }
    }

    
}
