using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SceneSelecter : MonoBehaviour
{
    public enum SceneType
    {
        Title,
        Main,
        Result
    }

    private SceneType sceneType;

    // Start is called before the first frame update
    void Start()
    {
        sceneType = (SceneType)Enum.Parse(typeof(SceneType), SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            switch(sceneType)
            {
                case SceneType.Title:
                    SceneManager.LoadScene(SceneType.Main.ToString());
                    break;
                case SceneType.Result:
                    SceneManager.LoadScene(SceneType.Title.ToString());
                    break;
                default:
                    break;

            }
        }
    }
}
