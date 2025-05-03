using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{

    public Transform Personaje;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        int MoverX =
            Input.GetKey(KeyCode.A) ? -1 :
            Input.GetKey(KeyCode.D) ? 1 : 0
        ;

        Debug.Log(MoverX);

    }
}
