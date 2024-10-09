using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    /**
    * Descripción: Script que crea los animales
    * Autor: Ángel Uriel Elías Velázquez
    * 
    * */

    public GameObject[] animales;
    void Start()
    {
        InvokeRepeating("CreateAnimal", 2, 3); //Invocar el método para crear animales cada dos segundos
    }


    //método para la creacion de animales
    void CreateAnimal()
    {
        int index = Random.Range(0, 3); //generación random del animal
        int posX = Random.Range(-20, 20); //ubicación aleatoria de generación

        animales[index].transform.position = new Vector3(posX,
            animales[index].transform.position.y,
            animales[index].transform.position.z);

        Instantiate(animales[index], animales[index].transform.position, animales[index].transform.rotation);

    }
}
