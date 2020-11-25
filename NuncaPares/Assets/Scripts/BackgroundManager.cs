using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    public List<GameObject> fondos;
    private GameObject actual, siguiente;


    // Start is called before the first frame update
    void Start()
    {
        actual = fondos[0];
        siguiente = fondos[1];
        
        // Instanciar gameObjects iniciales
        actual = Instantiate (actual, new Vector3(0,0,9.11f), Quaternion.identity) as GameObject;
        actual.transform.SetParent (GetComponent<Transform>());
        siguiente = Instantiate (siguiente, new Vector3(0,18,9.11f), Quaternion.identity) as GameObject;
        siguiente.transform.SetParent (GetComponent<Transform>());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            moverFondos();
    }

    void moverFondos()
    {
        actual.transform.Translate(0,-5*Time.deltaTime,0);
        siguiente.transform.Translate(0,-5*Time.deltaTime,0);
    }
    
    
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        Destroy(actual);
        actual = siguiente;
        
    }
}
