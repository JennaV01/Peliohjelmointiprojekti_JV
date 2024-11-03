using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject gameoverUI;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void gameOver()
    {
        gameoverUI.SetActive(true);
    }
}
