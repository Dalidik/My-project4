using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public float radius = 5.0F;
    public float power = 80.0F;
    public float lift = 60;
    public float speed = 90;
    public bool exploder = false;
     public ParticleSystem explosion;
    



    void FixedUpdate()
    {
        if (exploder)
        {
            Vector3 explosionPos = transform.position;
            Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
            foreach (Collider hit in colliders)
            {
                if (hit.GetComponent<Rigidbody>())
                {
                    hit.GetComponent<Rigidbody>().AddExplosionForce(power, explosionPos, radius, lift);
                }
            }
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            exploder = true;
             Instantiate(explosion, transform.position, Quaternion.identity);

          
        }
       
    }
}
