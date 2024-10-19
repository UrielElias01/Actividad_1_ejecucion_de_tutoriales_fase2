using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Nombre: Ángel Uriel Elías Velázquez
 * Descripción: 
 * Fecha: 16/10/2024
 */


// Clase Player hereda de Character
public class Player : Character
{
    public HealthBar healthBarPrefab; //Referencia HealthBar Prefab
    private HealthBar healthBar; //Copia de referencia de HealthBar Prefab
    private void Start()
    {
        healthBar = Instantiate(healthBarPrefab); //Instanciar HealthBar
        healthBar.character = this; //Referencia del Player en HealthBar
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CanBePickedUp"))
        {
            Item hitObject = collision.gameObject.GetComponent<Consumable>().item;
            if (hitObject != null)
            {
                Debug.Log("Nombre: " + hitObject.objectName);
                bool shouldDisappear = false;
                switch (hitObject.itemType)
                {
                    case Item.ItemType.COIN: //Moneda
                        shouldDisappear = true;
                        break;
                    case Item.ItemType.HEALTH://Barra de Salud
                       
                        shouldDisappear = AdjustHitPoints(hitObject.quantity);
                        Debug.Log("Cantidad a Incrementar: " + hitObject.quantity + " Desaparecer" + shouldDisappear);
                        break;
                }
                if (shouldDisappear)
                {
                    collision.gameObject.SetActive(false); //Desaparecer
                }
            }
        }
    }
    private bool AdjustHitPoints(int amount)
    {
        Debug.Log(hitPoints.value + "  " + maxHitPoints);
        if (hitPoints.value < maxHitPoints) // no se puede exceder el máximo de puntos
        {
            hitPoints.value = hitPoints.value + amount;
            print("Ajustando Puntos: " + amount + ". Nuevo Valor: " + hitPoints.value);
            return true; //Fue modificado
        }
        return false; //No se modifica entonces el Heart no desaparece
    }
}
