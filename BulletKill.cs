using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletKill : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if(col.gameObject.tag.Equals ("Bullet"))
            {
                Destroy (col.gameObject);
                Destroy (gameObject);
            }


    }
}
