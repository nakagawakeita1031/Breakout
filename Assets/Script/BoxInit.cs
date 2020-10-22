using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxInit : MonoBehaviour
{
    [Header("Boxの種類数")]
    public GameObject [] boxObjPrefabs;
    public GameObject boxesObj;

    [Header("Boxの行と列の設定値")]
    public int row;
    public int column;

     void Awake()
    {
        GameObject masterObj = GameObject.Find("Master");
     for (int x = 0; x < row; x++)
        {
            for (int y = 0; y < column; y++)
            {
                int randomValue = Random.Range(0, boxObjPrefabs.Length);
                GameObject g = Instantiate(boxObjPrefabs[randomValue], boxesObj.transform);
                g.transform.position = new Vector3((2f + (1f * y)), 0.4f, (-4.2f + (1.2f * x)));
                g.GetComponent<Destroyer>().masterObj = masterObj;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
