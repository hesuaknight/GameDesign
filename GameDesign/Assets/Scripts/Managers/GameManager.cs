using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour, IUpdate
{
    public static GameManager instance { get { return _instance; } }
    private static GameManager _instance;

    public float gameTime;

    [HideInInspector]
    public bool onPause;
    [HideInInspector]
    public float crrGametime;

    public void Awake()
    {
        if (_instance == null)
            _instance = this;
    }

    public void Update()
    {
        
    }

    public void AddTime()
    {
        gameTime += 30;
    }

    public void OnPause()
    {
        onPause = !onPause;
        UIManager.instance.pause.SetActive(onPause);
    }

    public void GameOver()
    {
        onPause = !onPause;
        UIManager.instance.gameOver.SetActive(true);
    }

    public void LevelComplete()
    {
        onPause = !onPause;
        UIManager.instance.levelComplete.SetActive(true);
    }

    public void LevelUp()
    {
        UIManager.instance.levelComplete.SetActive(false);
        UIManager.instance.levelUp.SetActive(true);
    }

    public void NextLevel()
    {
        onPause = !onPause;
        UIManager.instance.levelUp.SetActive(false);
        GenerateLevel();
    }

    public void GenerateLevel()
    {

    }
}
