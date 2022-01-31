using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "animal")
        {
            //col.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
        else if(col.gameObject.tag != "loseWall")
        {
            //Destroy(gameObject);
        }

        
    }
}
