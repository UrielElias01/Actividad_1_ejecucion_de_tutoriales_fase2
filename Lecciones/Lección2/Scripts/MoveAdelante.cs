using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAdelante : MonoBehaviour
{
    /**
 * Descripción: Script que mueve al objeto
 * Autor: Ángel Uriel Elías Velázquez
 * 
 * */

    public float vel = 30F;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >35)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < -11) //Eliminar el animal
        {
            Destroy(gameObject);
        }

        transform.Translate(Vector3.forward * Time.deltaTime * vel );
    }
}
