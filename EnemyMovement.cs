using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyMovement : MonoBehaviour
{
    public static EnemyMovement instance;
    public Transform player;

    private float RandomSpeed;
    private float rangeZ = -12f;



    void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }


    public void Move()
    {
        RandomSpeed = Random.Range(2f, 7f);
        transform.position = Vector3.MoveTowards(transform.position, player.position, RandomSpeed * Time.deltaTime);

    }

   
}
