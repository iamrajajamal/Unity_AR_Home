﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ChangeScene(string name)
    {
        SceneManager.LoadSceneAsync(name);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
