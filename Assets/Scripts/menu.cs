using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void quitGame()
    {
        Application.Quit(0);
    }
}
