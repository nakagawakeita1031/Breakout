using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public int point;
    public GameObject masterObj;

    public int initHp;
    private int currentHp;

    public AudioClip hitSE;
    public AudioClip DestroySE;

    public Renderer rend;
    private ChangeColorOnHit changeColorOnHit;

    // Start is called before the first frame update
    void Start()
    {
        this.currentHp = initHp;

        changeColorOnHit = masterObj.GetComponent<ChangeColorOnHit>();
        rend.material.color = changeColorOnHit.ChangeMaterialColor(currentHp);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnCollisionEnter(Collision collision)
    {
        this.currentHp -= 1;

        if (this.currentHp <= 0)
        {
            AudioSource.PlayClipAtPoint(DestroySE, transform.position);
            masterObj.GetComponent<GameMaster>().boxNum--;
            FindObjectOfType<Score>().AddPoint(point);
            Destroy(this.gameObject);
        }
        else
        {
            AudioSource.PlayClipAtPoint(hitSE, transform.position);
            ChangeBlockColor();
        }
       
     
        
    }
}
