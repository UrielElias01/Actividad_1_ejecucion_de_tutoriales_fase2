using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    /**
    * Descripci�n: Script que crea los animales
    * Autor: �ngel Uriel El�as Vel�zquez
    * 
    * */

    public GameObject[] animales;
    void Start()
    {
        InvokeRepeating("CreateAnimal", 2, 3); //Invocar el m�todo para crear animales cada dos segundos
    }


    //m�todo para la creacion de animales
    void CreateAnimal()
    {
        int index = Random.Range(0, 3); //generaci�n random del animal
        int posX = Random.Range(-20, 20); //ubicaci�n aleatoria de generaci�n

        animales[index].transform.position = new Vector3(posX,
            animales[index].transform.position.y,
            animales[index].transform.position.z);

        Instantiate(animales[index], animales[index].transform.position, animales[index].transform.rotation);

    }
}
