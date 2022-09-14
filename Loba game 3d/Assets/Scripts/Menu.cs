using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    void Start ()
    {
        Cursor.visible = true;
    }

    public void PlayEndlessMode()
    {
        SceneManager.LoadScene("Endless mode");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
