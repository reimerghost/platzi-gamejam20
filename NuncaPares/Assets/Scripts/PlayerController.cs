﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float speed = 0.15f;
    private Animator _anima;
    private float _deadzone;
    public float direction;

    private Collider2D _hitboxHero;
    private String _objetivo;
    private GameObject _escudo;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _anima = GetComponent<Animator>();
        _escudo = GameObject.Find("/Robot/Escudo");
        _escudo.SetActive(false);
        _hitboxHero = GetComponent<CapsuleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxis("Horizontal");
        transform.Translate(direction*speed*Time.deltaTime,0,0);
        _anima.SetFloat("dir",direction);
        
        if(Input.GetKeyDown(KeyCode.X))
            _anima.SetBool("impulsa",true);
        if(Input.GetKeyUp(KeyCode.X))
            _anima.SetBool("impulsa",false);
        if(Input.GetKeyDown(KeyCode.C))
            _anima.SetBool("damaged",true);
        if(Input.GetKeyUp(KeyCode.C))
            _anima.SetBool("damaged",false);
        if(Input.GetKeyDown(KeyCode.Space))
            _escudo.SetActive(true);
        if(Input.GetKeyUp(KeyCode.Space))
            _escudo.SetActive(false);
        
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        _objetivo = other.gameObject.tag;
        Debug.Log(_objetivo);
        switch (_objetivo)
        {
            case "Pared":
                _anima.SetBool("damaged",true);
                break;
            case "Tope":
                break;
        }
    }private void OnCollisionExit2D(Collision2D other)
    {
        _objetivo = other.gameObject.tag;
        Debug.Log(_objetivo);
        switch (_objetivo)
        {
            case "Pared":
                _anima.SetBool("damaged",false);
                break;
            case "Tope":
                break;
        }
    }
}
