﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//============
// Probably don't need it anymore
//============

public class ExitGameScript : MonoBehaviour
{
    [SerializeField] public Button startGameBtn;
    [SerializeField] public Button quitBtn;
    
    // Start is called before the first frame update
    void Start()
    {
        startGameBtn = GameObject.Find("StartGameButton").GetComponent<Button>();
        startGameBtn.onClick.AddListener(StartGame);

        quitBtn = GameObject.Find("QuitButton").GetComponent<Button>();
        quitBtn.onClick.AddListener(QuitGame);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    void StartGame()
    {
        Debug.Log("Start Game");
        SceneManager.LoadScene("PlayerSelection");
    }

    void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
