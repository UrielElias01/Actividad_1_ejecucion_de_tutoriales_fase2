using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

/*
* nombre: Ángel Uriel Elías Velázquez
* descripción: Script para controlar el movimiento de un objeto en Unity. Permite moverlo hacia adelante/atrás y girar con las teclas de dirección. 
*              La velocidad de movimiento y giro se pueden ajustar mediante las variables públicas.
* fecha: (coloca aquí la fecha actual)
*/

public class MoveMamalon : MonoBehaviour
{
    // Variables que almacenan los valores de entrada del usuario
    float inputVertical; // Movimiento hacia adelante y hacia atrás
    float inputHorizontal; // Movimiento de giro (izquierda/derecha)

    // Variable pública para controlar la velocidad de movimiento
    public float velocidad = 10;

    // Variable privada para controlar la velocidad de giro
    float giro = 40;

    // Método Start se ejecuta al inicio del juego. Actualmente está vacío.
    void Start()
    {
        
    }

    // Método Update se ejecuta en cada frame y maneja el movimiento del objeto
    void Update()
    {
        // Captura las entradas del usuario para el movimiento horizontal y vertical
        inputHorizontal = UnityEngine.Input.GetAxis("Horizontal"); // Teclas izquierda/derecha
        inputVertical = UnityEngine.Input.GetAxis("Vertical"); // Teclas arriba/abajo

        // Mueve el objeto hacia adelante o hacia atrás dependiendo de la entrada del usuario
        transform.Translate(Vector3.back * Time.deltaTime * velocidad * inputVertical);

        // Rota el objeto alrededor de su eje Y (arriba) basado en la entrada horizontal
        transform.Rotate(Vector3.up, Time.deltaTime * giro * inputHorizontal);
    }
}
