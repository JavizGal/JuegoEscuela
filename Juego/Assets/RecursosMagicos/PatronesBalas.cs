using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PatronesBalas : MonoBehaviour
{
    // Start is called before the first frame update

    private int BalasEncontradas = 0;
    private float[] PosicionesX = new float[50];
    private float[] PosicionesY = new float[50];
    private float[] PatronesBala = new float[50];
    private Image[] Balas = new Image[50];

    void Start()
    {
        EncontrarBalas();
    }

    // Update is called once per frame
    void Update()
    {
        MoverBalas();
    }

    void EncontrarBalas()
    {
        for(int i = 0; i < 50; i++)
        {
            if (GameObject.Find($"Balita{i+1}"))
            {
                Balas[i] = GameObject.Find($"Balita{i+1}").GetComponent<Image>();
                PosicionesX[i] = Balas[i].transform.position.x;
                PosicionesY[i] = Balas[i].transform.position.y;
                PatronesBala[i] = 0;
                BalasEncontradas++;
            }
        }
        Debug.Log(BalasEncontradas);

    }

    void MoverBalas()
    {
        if (BalasEncontradas == 3)
        {
            Patron1_1(1);
        }
    }

    void Patron1_1(int NumeroDeBala)
    {
        if (Balas[NumeroDeBala].rectTransform.position.y < -300)
        {
            PatronesBala[NumeroDeBala] = 1;
        }
        if (PatronesBala[NumeroDeBala] == 0)
        {
            MovimientoIndividual(NumeroDeBala, 1, -1);
        }

        if (PatronesBala[NumeroDeBala] == 1)
        {
            MovimientoIndividual(NumeroDeBala, 1, 1);
        }

        
        
    }

    void MovimientoIndividual(int NumeroBala, int VelocidadX, int VelocidadY)
    {
        Balas[NumeroBala].rectTransform.position = new Vector2(PosicionesX[NumeroBala], PosicionesY[NumeroBala]);
        PosicionesX[NumeroBala] += VelocidadX;
        PosicionesY[NumeroBala] += VelocidadY;
    }

}
