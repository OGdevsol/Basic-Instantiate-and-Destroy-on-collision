using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camScript : MonoBehaviour
{
    

    public GameObject player;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
         offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        CamFollow();
    }
    
    public void CamFollow()
    {
        transform.position = player.transform.position + offset;
            /*Vector3 pos = new Vector3(player.transform.position.x, player.transform.position.y,
            player.transform.position.z)*Time.deltaTime;*/
            
    }
}
