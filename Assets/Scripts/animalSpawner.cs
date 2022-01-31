using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class animalSpawner : MonoBehaviour
{
    [SerializeField] private GameObject animalPrefab, animal2Prefab, animal3Prefab;
    private float nextAnimalTime, nextAnimal2Time, nextAnimal3Time;
    private float animalTimeChange = 3.0f;
    private float animal2TimeChange = 15.0f;
    private float animal3TimeChange = 30.0f;
    public static int score;
    private TextMeshProUGUI scoreboard;
    
    void Start()
    {
        //spawns animal every #.0f seconds
        nextAnimalTime = Time.time + animalTimeChange;
        nextAnimal2Time = Time.time + animal2TimeChange;
        nextAnimal3Time = Time.time + animal3TimeChange;
        score = 0;
        scoreboard = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MainScene"))
        {
            if(Time.time > nextAnimal3Time)
            {
                Instantiate(animal3Prefab, transform.position, Quaternion.identity);
                nextAnimal3Time += animal3TimeChange;
                if(animal3TimeChange > 0.4)
                {
                    animal3TimeChange -= 0.5f;
                }
                score += 30;
            }
            else if(Time.time > nextAnimal2Time)
            {
                Instantiate(animal2Prefab, transform.position, Quaternion.identity);
                nextAnimal2Time += animal2TimeChange;
                if(animal2TimeChange > 0.4)
                {
                    animal2TimeChange -= 0.3f;
                }
                score += 20;
            }
            else if(Time.time > nextAnimalTime)
            {
                Instantiate(animalPrefab, transform.position, Quaternion.identity);
                nextAnimalTime += animalTimeChange;
                if(animalTimeChange > 0.4)
                {
                    animalTimeChange -= 0.1f;
                }
                
                score += 5;
            }

            setScore();
        }
    }

    void setScore()
    {
        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MainScene"))
        {
            scoreboard.text = $"Score: {score}";
            PlayerPrefs.SetInt("score", score);
        }
    }
}
