using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }

    public void QuitGame ()
    {   //kun main menun quit nappia painetaa debug logiin tulee teksti GAME OVER! ja peli sulkeutuu
        Debug.Log("QUIT");
        Application.Quit();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
