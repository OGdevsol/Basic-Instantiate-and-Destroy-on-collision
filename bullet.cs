using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public static bullet instance;
    public GameObject BulletToBeDestroyed;
    public GameObject Explosion;
    private Animator anim;
    public float zRange=12f;

    public bool ExplosionIsOn;
    public int CurrentScore;
   // public int scoreIncrement=10;

    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Destroy_Bullet();
       
    }

    
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag=="Enemy")
        {
            Destroy(other.gameObject);
            Instantiate(Explosion, other.transform.position, Explosion.transform.rotation);
            ExplosionIsOn = true;
            Destroy(gameObject);
           // SetScore();
        }
       
      
    }
     public void Destroy_Bullet()
    {
        if (BulletToBeDestroyed.transform.position.z>=zRange)
        {
            Destroy(gameObject);
        }
    }

     private IEnumerator WaitBeforeDestroyin()
     {
         yield return new WaitForSeconds(1f);
         Destroy(Explosion);
     }
}
