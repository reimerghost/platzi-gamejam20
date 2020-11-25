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

    private Collider2D _hitboxHero;
    private String _objetivo;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _anima = GetComponent<Animator>();
        _hitboxHero = GetComponent<CapsuleCollider2D>();
        _hitboxHero.isTrigger = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        direction = Input.GetAxis("Horizontal");
        transform.Translate(direction*speed*Time.deltaTime,0,transform.position.z);
        _anima.SetFloat("dir",direction);
        
        if(Input.GetKeyDown(KeyCode.X))
            _anima.SetBool("impulsa",true);
        if(Input.GetKeyUp(KeyCode.X))
            _anima.SetBool("impulsa",false);
        if(Input.GetKeyDown(KeyCode.C))
            _anima.SetBool("damaged",true);
        if(Input.GetKeyUp(KeyCode.C))
            _anima.SetBool("damaged",false);
        
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        _objetivo = other.gameObject.tag;
        Debug.Log(_objetivo);
        switch (_objetivo)
        {
            case "Pared":
                _anima.SetFloat("dir",0);
                _anima.SetBool("damaged",true);
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
        }
    }
}
