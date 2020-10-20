﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelecter : MonoBehaviour
{
    private string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            switch(sceneName)
            {
                case "Title":
                    SceneManager.LoadScene("Main");
                    break;
                case "Result":
                    SceneManager.LoadScene("Title");
                    break;
                default:
                    break;

            }
        }
    }
}
