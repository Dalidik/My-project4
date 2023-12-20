using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public ParticleSystem explosion;
    private GameObject clone;

    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(explosion, 2f);
           
            
        }
          

    }

    
}
