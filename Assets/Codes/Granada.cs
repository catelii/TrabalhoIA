﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granada : MonoBehaviour
{

    public float bombForce=1000;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Explode", 3);
    }

    void Explode()
    {
        print("Boom!");
        Destroy(gameObject);
        RaycastHit[] hits;
        hits=Physics.SphereCastAll(transform.position, 5, Vector3.up, 10);



        if (hits.Length > 0)
        {
            foreach(RaycastHit hit in hits)
            {
                if (hit.rigidbody)
                {
                    hit.rigidbody.isKinematic = false;
                    hit.rigidbody.AddExplosionForce(bombForce, transform.position, 10);
                }
            }
        }
    }
}
