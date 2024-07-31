using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    [SerializeField] float reloadDelay = 1f;
    [SerializeField] ParticleSystem finishParticles;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Debug.Log("Congrats!");
            finishParticles.Play();
            Invoke("Restart", reloadDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
