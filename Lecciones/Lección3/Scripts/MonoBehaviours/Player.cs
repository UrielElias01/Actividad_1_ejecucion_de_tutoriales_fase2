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
    //Método invocado cuando otro collider colisiona

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //verifica si el objeto colisionado tiene como etiqueta CanBePickeUp
        if (collision.gameObject.CompareTag("CanBePickedUp"))
        {
            Item hitObject = collision.gameObject.GetComponent<Consumable>().item;

            if (hitObject != null)
            {
                //ocultamos el objeto de la escena
                print("Nombre: "+hitObject.objectName);

                switch(hitObject.itemType)
                {
                    case Item.ItemType.COIN:
                        break;
                    case Item.ItemType.HEALTH:
                        AdjusHitPoitns(hitObject.quantity); 
                        break;
                    default:
                        break;
                }

                collision.gameObject.SetActive(false);
            }
        }
    }

    public void AdjusHitPoitns(int amount)
    {
        hitPoints = hitPoints + amount;
        print("Ajustando puntos: " + amount + ". Nuevo Valor: " + hitPoints);
    }


}
