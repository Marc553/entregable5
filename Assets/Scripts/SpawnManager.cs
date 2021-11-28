using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab; //coge el gameobject asignado 
    public Vector3 spawnPos = new Vector3(0, 0, 30); //posicion d odnde saldran los objetos
   
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 0.5f, 5f); //lleva acabo la accion d spawnear los obstaculos a partir de 0.5s d emepezar y acada 5s se activa
    }

    //crea la posicion d spwan del obstaculo, a una Y variable entre -10 y 10, y a +50 del player, manteniendo su rotacion inicial
    public void SpawnObstacle()
    {
        float randomY = Random.Range(-10, 10);  
        spawnPos = new Vector3(0, randomY, spawnPos.z + 50);
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }

}
