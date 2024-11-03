using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//t‰m‰ scripti on laitettu Obstaclelle ja Backgroundille
public class MoveLeft : MonoBehaviour

{
    private float speed = 30;
    private PlayerController playerControllerScript;
    private float leftBound = -15;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {   //jos peli ei ole p‰‰ttynyt este ja tausta liikkuu vasemmalle aiemmin p‰‰tettyjen arvojen mukaan
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        //tuhoaa esteen kun se on ylitt‰nyt leftBoundille asetetun arvon
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}