using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyExplosion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {InvokeRepeating("wait", 1, 1 );
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void wait()
    {
        
        Destroy(gameObject);
    }
    
}
