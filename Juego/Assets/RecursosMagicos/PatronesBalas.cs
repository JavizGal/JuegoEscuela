using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PatronesBalas : MonoBehaviour
{
    // Start is called before the first frame update

    private int BalasEncontradas;
    private Image[] Balas = new Image[50];

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void EncontrarBalas()
    {
        for(int i = 0; i < 50; i++)
        {
            if (GameObject.Find($"Balita{i+1}"))
            {
                Balas[i] = GameObject.Find($"Balita{i+1}").GetComponent<Image>();
                BalasEncontradas ++;
            }
        }

        Console.Write(BalasEncontradas);

     //   MoverBalas();
    }

    void MoverBalas()
    {
        if (BalasEncontradas == 3)
        {
            MovimientoDe3();
        }
    }

    void MovimientoDe3()
    {
        Balas[1].transform.position = new Vector3(1, 1, 1);
    }

}
