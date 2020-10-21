﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    public int boxNum;
    public float nowTime;
    [SerializeField] Text resultMessageText;
    private bool isClear;

    // Start is called before the first frame update
    void Start()
    {
        nowTime = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        nowTime += Time.deltaTime;
        if (!isClear)
        {
            if (boxNum <= 0)
            {
                StageClear(nowTime.ToString("F0") + "秒でクリアできた！");
                isClear = true;
            }
        }
        
    }

    void StageClear(string resultMessage)
    {
        resultMessageText.text = resultMessage;
        FindObjectOfType<LevelManager>().LevelUP();
    }

    public void GameOver(string resultMessage, bool isClear)
    {
        DataSender.resultMessage = resultMessage;
        DataSender.isGameClear = isClear;
        SceneManager.LoadScene("Result");
    }
}
