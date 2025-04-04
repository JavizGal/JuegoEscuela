using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void CambiarPantalla(string NombreEscena)
    {
        SceneManager.LoadScene(NombreEscena);
    }

}
