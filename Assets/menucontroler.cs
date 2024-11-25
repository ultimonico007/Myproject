using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucontroler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 1;
    }
    public void Startgame()
    {
        SceneManager.LoadScene("principal");
    }

    // Update is called once per frame
    public void quitgame()
    {
        Application.Quit();
    }

}
