using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clock : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D other)
    {
        // E�er karakter saat nesnesine dokunursa
        if (other.gameObject.tag == "Player")
        {
            // Biti� sahnesine ge�i� yap
            SceneManager.LoadScene(4);
        }
    }

}