﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    public static GameControl instance;
    public GameObject gameOverText;
    public bool gameOver = false;
    public Text scoreText;
    public float scrollSpeed = -1.5f;
    private int score = 0;
	void Awake ()
    {
		if(instance==null)
        {
            instance = this;
        }
        else if(instance !=null)
        {
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(gameOver==true&&Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
	}
    public void BirdScored()
    {
        if (gameOver)
            return;
        else score++;
        scoreText.text = "Score: " + score.ToString();
    }
    public void BirdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
