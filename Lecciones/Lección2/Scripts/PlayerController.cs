using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Descripción: Script que mueve el player
 * Autor: Ángel Uriel Elías Velázquez
 * 
 * */


public class PlayerController : MonoBehaviour

{
    public GameObject proyectil;
    public float vel = 170F;
    void Start()
    {
        
    }

    private Transform GetTransform()
    {
        return transform;
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        if(transform.position.x > 23)
        {
            transform.position = new Vector3(20,
                transform.position.y,
                transform.position.z);
        }else if (transform.position.x < -23)
        {
            transform.position = new Vector3(-20,
                transform.position.y,
                transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Disparar la comida
            Instantiate(proyectil, transform.position,proyectil.transform.rotation);  
        }

        transform.Translate(Vector3.right*Time.deltaTime*vel*x);
    }
}
