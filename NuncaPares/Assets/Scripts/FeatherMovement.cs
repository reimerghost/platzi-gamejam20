﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeatherMovement : MonoBehaviour
{
    public Rigidbody2D featherRb;
    public float speed =1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        featherRb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
    }
}
