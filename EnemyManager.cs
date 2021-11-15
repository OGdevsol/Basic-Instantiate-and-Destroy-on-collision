using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyManager : MonoBehaviour
{
    private int EnemyRandomIndex;
    private int EnemyRandomPosition;
    public GameObject[] Enemies;
    private float spawnPosX;
    private float spawnPosY=0.5f;
    private float rangeZ=12;
    private float spawnPosZ;
    public Transform TargetPosition;
    

    
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("InstantiateEnemy", 2f, 2f);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantiateEnemy()
    {
       
       
        EnemyRandomIndex = Random.Range(1, 4);
        spawnPosX = Random.Range(-12, 12);
        spawnPosZ = Random.Range(3, 8);
        Vector3 newEnemyPos = new Vector3(spawnPosX, spawnPosY, spawnPosZ);
        Instantiate(Enemies[EnemyRandomIndex], newEnemyPos, Enemies[EnemyRandomIndex].transform.rotation );

    }

   
  
}
