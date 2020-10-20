using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnHit : MonoBehaviour
{
    public Color[] blockColors;

    public Color ChangeMaterialColor(int index)
    {
        index--;
        return blockColors[index];
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
