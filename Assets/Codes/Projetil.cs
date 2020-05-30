using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    public bool destruir;
    public GameObject efeito;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Inimigo")
        {
            Life life = col.gameObject.GetComponent<Life>();
            life.life = life.life - 200;
        }

        if (destruir)
        {
            Instantiate(efeito, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
