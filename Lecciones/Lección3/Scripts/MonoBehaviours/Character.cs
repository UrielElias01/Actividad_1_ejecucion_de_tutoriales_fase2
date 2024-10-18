using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Nombre: Ángel Uriel Elías Velázquez
 * Descripción: 
 * Fecha: 16/10/2024
 */

//clase genérica para todo tipo de personaje en el juego 

public abstract class Character : MonoBehaviour
{
    public int hitPoints;   //puntos de vida actuales
    public int macHitPoints;    //puntos de vida máximos
}