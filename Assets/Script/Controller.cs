using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [Header("Playerの移動速度")]
    public float playerSpeed;

    [Header("Playerの移動範囲の制限値")]
    public float limitPos = 4.25f;

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
        float z = Mathf.Clamp(transform.position.z, -limitPos, limitPos);

        transform.position = new Vector3(transform.position.x, transform.position.y, z);
    }
}
