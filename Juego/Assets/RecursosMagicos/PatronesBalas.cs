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
            Balas[i] = GameObject.Find($"Balita{i+1}").getComponent<Image>();
        }

        MoverBalas();
    }

    void Mover

}
