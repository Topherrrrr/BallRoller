using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnLogic : MonoBehaviour
{
    public Vector3 spawnPoint;
    int checkpointIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Respawn()
    {
        gameObject.transform.position = spawnPoint;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Enemy")
        {
            Respawn();
        }
        if(other.gameObject.tag=="CheckPoint")
        {
            CheckpointActivate checkpointScript = other.gameObject.GetComponent<CheckpointActivate> ();
            if (checkpointScript.PointID > checkpointIndex)
            {
                checkpointIndex = checkpointScript.PointID;
                spawnPoint = other.gameObject.transform.position + new Vector3(0, 1, 0);
            }
        }
    }
}
