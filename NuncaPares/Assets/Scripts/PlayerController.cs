using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float speed = 0.15f;
    private Animator _anima;
    private float _deadzone;
    public float direction;
    //private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        _anima = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxis("Horizontal");
        transform.Translate(direction*speed*Time.deltaTime,0,transform.position.z);
        _anima.SetFloat("dir",direction);
        Debug.Log(direction);
    }

    private void FixedUpdate()
    {
        
    }
}
