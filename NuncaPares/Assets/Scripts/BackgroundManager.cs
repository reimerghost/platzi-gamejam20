using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundManager : MonoBehaviour
{
    public float scrollSpeed;
    
    public List<GameObject> fondos;
    private GameObject actual, siguiente, anterior;
    
    private int index = 0;


    // Start is called before the first frame update
    void Start()
    {
        actual = fondos[index];
        // Instanciar gameObjects iniciales
        actual = Instantiate (actual, new Vector3(0,0,9.11f), Quaternion.identity) as GameObject;
        actual.transform.SetParent (GetComponent<Transform>());
        actual.name = "bloque_" + index;
        index++;
        
        siguiente = fondos[index];
        siguiente = Instantiate (siguiente, new Vector3(0,18,9.11f), Quaternion.identity) as GameObject;
        siguiente.transform.SetParent (GetComponent<Transform>());
        siguiente.name = "bloque_" + index;
        index++;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoverFondos();
    }


    private float desp;
    private float distancia;
    
    void MoverFondos()
    {
        desp = -scrollSpeed * Time.deltaTime;
        distancia += desp;
        
        actual.transform.Translate(0,desp,0);
        siguiente.transform.Translate(0,desp,0);

        if ((distancia > -18f)) return;
        anterior = actual;
        actual = siguiente;
        
        if (index < fondos.Count )
        {
            siguiente = fondos[index];
            siguiente = Instantiate (siguiente, new Vector3(0,18,9.11f), Quaternion.identity) as GameObject;
            siguiente.transform.SetParent (GetComponent<Transform>());
            siguiente.name = "bloque_" + index;
            index++;
        }
        else
        {
            SceneManager.LoadScene("Scenes/Dreamland");
        }

        Destroy(anterior);
        distancia = 0;
    }

}