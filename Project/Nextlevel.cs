using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nextlevel : MonoBehaviour
{

    private Scene sc;

    private void Awake()
    {
        sc=SceneManager.GetActiveScene();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(sc.buildIndex +1);
        }
    }

    public void Startnext()
    {
        SceneManager.LoadScene(sc.buildIndex + 1);
    }

}
