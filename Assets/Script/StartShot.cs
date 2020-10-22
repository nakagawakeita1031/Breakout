using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartShot : MonoBehaviour
{
    public float addSpeed;

    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = new Vector3(0, Random.Range(30, 120), 0);
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * (500 + (LevelManager.level * addSpeed)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BallDestroy()
    {
        this.gameObject.SetActive(false);
        Destroy(this.gameObject);
    }
}
