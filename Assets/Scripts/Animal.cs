using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Animal : MonoBehaviour
{
    private NavMeshAgent agent; 
    [SerializeField] private int animalType;
    [SerializeField] private int weight;
    [SerializeField] private int speed; // multiply by deltaTime later
    private Transform player;


    // Start is called before the first frame update
    void Start()
    {
        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MainScene"))
        {
            player = GameObject.FindWithTag("Player").transform;
            agent = GetComponent<NavMeshAgent>();
            gameObject.GetComponent<Rigidbody>().mass = weight;
            agent.speed = speed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MainScene"))
        {
            if(animalType == 1)
            {
                Destroy(gameObject, 10);
            }
            else if(animalType == 2)
            {
                Destroy(gameObject, 15);
            }
            else if(animalType == 3)
            {
                Destroy(gameObject, 20);
            }

            agent.SetDestination(player.position);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "loseWall")
        {
            SceneManager.LoadScene("LossMenu");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
