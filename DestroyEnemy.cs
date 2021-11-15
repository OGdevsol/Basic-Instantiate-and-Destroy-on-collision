using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public float rangeZ = -12f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkPos();
    }

    public void checkPos()
    {
        if (transform.position.z<=rangeZ)
        {
            Destroy(gameObject);
        }
    }
}
