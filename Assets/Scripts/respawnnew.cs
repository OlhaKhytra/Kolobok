using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class respawnnew : MonoBehaviour
{
    private Scene scene;
    
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
          
            SceneManager.LoadScene(scene.name);
            //Application.LoadLevel(scene.name);
        }
    }
}
