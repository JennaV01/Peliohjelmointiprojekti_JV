using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;
    public Text scoreText;

    int score = 0;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        scoreText.text = score.ToString() + " POINTS";
    }

    public void AddPoint()
    {   //lis‰‰ yhden pisteen aina kun jokin asia tehd‰‰n. T‰ss‰ peliss‰ se asia on hypp‰‰minen ja olen lis‰nnyt PlayerController scriptiin rivin joka t‰m‰n funkiton kautta lis‰‰ aina piseen kun pelaaja hypp‰‰
        score += 1;
        scoreText.text = score.ToString() + " POINTS";
    }
}
