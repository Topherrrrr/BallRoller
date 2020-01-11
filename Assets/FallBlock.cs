using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallBlock : MonoBehaviour
{
    public Color start, end;
    public float speed = 1f;
    public float startTime;
    float fallTime = 1f;
    bool touched = false;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (touched)
        {
            fallTime -= Time.deltaTime;
            float T = (Time.time - startTime) * speed;
            GetComponent<Renderer>().material.color = Color.Lerp(start, end, T);
            if(fallTime <= 0)
            {
                GetComponent<Rigidbody>().useGravity = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            touched = true;
        }
    }
}
