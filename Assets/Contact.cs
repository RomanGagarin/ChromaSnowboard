using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Contact : MonoBehaviour
{
    [SerializeField] ParticleSystem snow;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            snow.transform.position = collision.transform.position;
            snow.Play();
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            snow.transform.position = collision.transform.position;
            snow.Play();
        }
    }

}
