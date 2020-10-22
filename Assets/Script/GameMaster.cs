using System.Collections;
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
    [SerializeField] private Score score;

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
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
    }

    void StageClear(string resultMessage)
    {
        score.Save();
        resultMessageText.text = resultMessage;
        FindObjectOfType<LevelManager>().LevelUP();
    }

    public void GameOver(string resultMessage, bool isClear)
    {
        score.Save();
        DataSender.resultMessage = resultMessage;
        DataSender.isGameClear = isClear;
        SceneManager.LoadScene("Result");
    }
}
