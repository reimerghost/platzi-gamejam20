using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicio : MonoBehaviour
{
    public void cargarEscena(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
