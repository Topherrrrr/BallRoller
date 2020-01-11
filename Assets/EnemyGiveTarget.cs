using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGiveTarget : MonoBehaviour
{
    public GameObject coreObject;
    EnemyMover core;
    // Start is called before the first frame update
    void Start()
    {
        core = coreObject.GetComponent<EnemyMover>(); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = coreObject.transform.position;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            core.tracking = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            core.tracking = false;
        }
    }
}
