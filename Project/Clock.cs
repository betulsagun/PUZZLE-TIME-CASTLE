using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clock : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D other)
    {
        // Eðer karakter saat nesnesine dokunursa
        if (other.gameObject.tag == "Player")
        {
            // Bitiþ sahnesine geçiþ yap
            SceneManager.LoadScene(4);
        }
    }

}