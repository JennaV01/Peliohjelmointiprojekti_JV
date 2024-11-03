using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//tänä scripti on laitettu Backgroundille

public class RepeatBackround : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;

    void Start()
    {   //toistaa 2 taustaa
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }


    void Update()
    {   //looppaa taustan
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}