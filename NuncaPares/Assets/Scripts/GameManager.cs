using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    static private GameManager _instancia;

    public int nivel;
    public int puntos;
    public float bateria;
    
    public float valorTimeScale;

    private void Awake()
    {
        if (_instancia == null)
            _instancia = this;
        else if (_instancia != this)
            Destroy(gameObject);    
        DontDestroyOnLoad(gameObject);

        nivel = 1;
        puntos = 0;
        bateria = 100;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cambiarEscena(string escena) {
        SceneManager.LoadScene(escena);
    }
    
    public void pausar(){
        // si esta activo lo pausamos
        if(Time.timeScale > 0)
        {
            valorTimeScale = Time.timeScale;
            Time.timeScale = 0;
        }
        // sino, quitamos la pausa
        else{
            quitarPausa();
        }
    }
    public void quitarPausa(){
        if(Time.timeScale == 0) Time.timeScale = valorTimeScale;
    }
}
