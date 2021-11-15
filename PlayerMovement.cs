using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform rayOrigin;

    public int movementSpeed;

    private Rigidbody playerRb;
    public Rigidbody bullet;
    public Transform bulletOrigin;

    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
      

    }

    // Update is called once per frame
    void Update()
    {
      Move();
      Fire();
    }

    public void Move()
    {
        var horizontalMovement = Input.GetAxis("Horizontal");
        var verticalMovement = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalMovement, 0, verticalMovement)*Time.deltaTime;
        playerRb.AddForce(movement*movementSpeed);
    }

    

    public void Fire()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody bullettype;
            bullettype= Instantiate(bullet, bulletOrigin.position, bulletOrigin.rotation )as Rigidbody;
            bullettype.AddForce(Vector3.forward*35f);
        }
    }

   
   
}
