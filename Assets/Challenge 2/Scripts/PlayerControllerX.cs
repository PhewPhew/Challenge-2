﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public float firerate = 0.5f;

    private float nextfire = 0f;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
       if (Input.GetKeyDown(KeyCode.Space)&& Time.time > nextfire)
       {
           nextfire = Time.time + firerate;
           Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            
        }
    }
}
