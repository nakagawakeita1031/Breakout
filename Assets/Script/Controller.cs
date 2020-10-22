using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += transform.forward * playerSpeed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position -= transform.forward * playerSpeed;
        }
    }
}
