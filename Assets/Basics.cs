﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basics : MonoBehaviour
{

    //Player gameObject to be used in other scripts
    public GameObject player;
    public static GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = player;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
