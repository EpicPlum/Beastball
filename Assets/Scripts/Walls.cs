using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "animal" || col.gameObject.tag == "Player")
        {
            //end game
            //Debug.Log("animal");
        }
        else if(col.gameObject.tag == "ball")
        {
            //pass through
            //Debug.Log("ball");
        }
    }
}
