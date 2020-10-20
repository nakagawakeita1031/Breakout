using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] Text levelText;
    [SerializeField] StartShot startShot;

    public static int level;
    public static bool isStart;

    // Start is called before the first frame update
    void Start()
    {
        if (!isStart)
        {
            level = 0;
            isStart = true;
        }
        levelText.text = level.ToString();
    }

    public void LevelUP()
    {
        startShot.BallDestroy();
        level++;
        StartCoroutine("NextLevel");
    }

    IEnumerator NextLevel()
    {
        Debug.Log("Please press key");
        while (!Input.GetKey("space")) yield return null;
        SceneManager.LoadScene("Main");
        Debug.Log("Done!");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
