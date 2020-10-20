using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDataFetcher : MonoBehaviour
{
    public Text resultMessageText;

    public AudioClip[] audioClips;

    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        resultMessageText.text = DataSender.resultMessage;    
        if (DataSender.isGameClear)
        {
            audioSource.clip = audioClips[0];
        }
        else
        {
            audioSource.clip = audioClips[1];
        }
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
