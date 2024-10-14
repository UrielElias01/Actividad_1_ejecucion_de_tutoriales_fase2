using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Nombre: �ngel Uriel El�as Vel�zquez
 * Descripci�n: Script que permite que el jugador se mueva y que las
 *              animaciones actuen en funci�n del movimiento
 * Fecha: 12/10/2024
 */

public class MovementController : MonoBehaviour
{
    //Velocidad de personajes
    public float movementSpeed = 3.0f;

    //Representa la ubicaci�n del Player o Enemy
    Vector2 movement = new Vector2();

    //Referencia a RigidBody2D
    Rigidbody2D rb2d;

    Animator animator; //Referencia a componente animator 
    string animationState = "AnimationState"; //Variable en Animator

    enum charStates
    {
        walkEast = 1,
        walkWest = 3,
        walkSouth = 2,
        walkNorth = 4,
        idleSouth = 5
    }
    void Start()
    {
        //Establece el componente rigidbody2D enlazado
        rb2d = GetComponent<Rigidbody2D>();

        //Establece valor de componente Animator el objeto ligado 
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        this.UpdateState(); //Invoca el m�todo
    }

    /*
     * M�todo que define la definici�n a ejecutar en base al movimiento realizado
     * por el usuario
     */
    private void UpdateState()
    {
        if(movement.x > 0) //ESTE
        {
            animator.SetInteger(animationState, (int)charStates.walkEast);
        } 
        else if(movement.x < 0) //OESTE
        {
            animator.SetInteger(animationState, (int)charStates.walkWest);
        }
        else if (movement.y < 0) //NORTE
        {
            animator.SetInteger(animationState, (int)charStates.walkNorth);
        }
        else if (movement.y > 0) //SUR
        {
            animator.SetInteger(animationState, (int)charStates.walkSouth);
        }
        else //IDLE
        {
            animator.SetInteger(animationState, (int)charStates.idleSouth);
        }
    }

    private void FixedUpdate()
    {
        MoveCharacter();  //M�todo definido para ingresar a la direcci�n
    }

    private void MoveCharacter()
    {
        //captura los datos de entrada del usuario
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //Conserva el rango de velocidad 
        movement.Normalize();
        rb2d.velocity = movement * movementSpeed;
    }
}

