using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//t�m� scripti on laitettu SpawnManager peliobjektille

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScript;

    void Start()
    {   //aloittaa esteiden spawnaamisen noudattaen ylemp�n� annettuja arvoja
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void SpawnObstacle()
    {   //jos peli on k�ynniss�, esteet spawnaavat
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
        
    }
}
