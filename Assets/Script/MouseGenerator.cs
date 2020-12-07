using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseGenerator : MonoBehaviour
{
    public GameObject mousePrefab;
    float span = 3.0f;
    float delta = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject mouse = Instantiate(mousePrefab) as GameObject;
            float x = Random.Range(7, 0);
            float z = Random.Range(-4, 4);
            mouse.transform.position = new Vector3(x, 0, z);
        }
    }
}
