using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShooting : MonoBehaviour
{
    public GameObject ballPrefab;
    public GameObject playerCamera;
    public float ballDistance = 2f;
    public float shootForce = 1000;
    public menuManager menu;
    private Quaternion rot = new Quaternion(0, 88.4f, 0, 90);

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        ballPrefab.GetComponent<Rigidbody>().useGravity = false;

        //sets start position and rotation
        //transform.rotation = rot;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = rot;

        if(Input.GetMouseButtonDown(0) && !menu.paused)
        {
            Shoot();
        }
        
    }

    void Shoot()
    {
        GameObject ball = Instantiate(ballPrefab, playerCamera.transform.position + playerCamera.transform.forward * ballDistance, Quaternion.identity);
        ball.GetComponent<Rigidbody>().useGravity = true;
        ball.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * shootForce);
        Destroy(ball, 2);
    }

}
