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
        
        if(Input.GetKeyDown(KeyCode.X))
            _anima.SetBool("impulsa",true);
        if(Input.GetKeyUp(KeyCode.X))
            _anima.SetBool("impulsa",false);
        if(Input.GetKeyDown(KeyCode.C))
            _anima.SetBool("damaged",true);
        if(Input.GetKeyUp(KeyCode.C))
            _anima.SetBool("damaged",false);
        
        
    }

    private void FixedUpdate()
    {
        
    }
}
