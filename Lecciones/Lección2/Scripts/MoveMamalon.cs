using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class MoveMamalon : MonoBehaviour
{
    float inputVertical;
    float inputHorizontal;
    public float velocidad = 10;
    float giro = 40;
    void Start()
    {
        
    }

    
    void Update()
    {
        inputHorizontal = UnityEngine.Input.GetAxis("Horizontal");
        inputVertical = UnityEngine.Input.GetAxis("Vertical");
        transform.Translate(Vector3.back*Time.deltaTime*velocidad*inputVertical);
        transform.Rotate(Vector3.up, Time.deltaTime*giro*inputHorizontal);
    }
}
