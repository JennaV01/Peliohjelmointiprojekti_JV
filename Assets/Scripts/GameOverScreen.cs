using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    
    
    public void Setup()
    {
        gameObject.SetActive(true);
        
    }

    public void RestartButton()
    {   //kun restart nappia painetaan peli siirtyy Prototype 3 sceneen
        SceneManager.LoadScene("Prototype 3");
    }

    public void ExitButton()
    {   //kun main menu nappia painetaan peli siirtyy Menu sceneen
        SceneManager.LoadScene("Menu");
    }

}
