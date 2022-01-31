using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour
{
    [SerializeField] private GameObject Menu;
    public bool paused = false;
    private GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.FindGameObjectWithTag("Player").transform.Find("First Person Camera").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //paused = false;

        pause();
    }

    public void pause()
    {
        bool esc = Input.GetKeyDown(KeyCode.Escape);

        if(esc && !paused)
        {
            Menu.SetActive(true);
            Time.timeScale = 0;
            paused = true;
            camera.GetComponent<FirstPersonLook>().enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else if(esc && paused)
        {
            Menu.SetActive(false);
            Time.timeScale = 1;
            paused = false;
            camera.GetComponent<FirstPersonLook>().enabled = true;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    public void restartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void returnButton()
    {
        Menu.SetActive(false);
        
    }
}
