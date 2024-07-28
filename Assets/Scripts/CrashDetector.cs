using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    CircleCollider2D head;
    [SerializeField] float reloadDelay = 1f;
    void Start()
    {
        head = GetComponent<CircleCollider2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (head.isTrigger && collision.tag == "Ground") // figured out I have to do both, otherwise it "crashes" when touching finishLine
        {
            Debug.Log("Crashed!");
            Invoke("Restart", reloadDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
