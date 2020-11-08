using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class destroi : MonoBehaviour
{
    public int Respawn;
    void OnTriggerEnter(Collider other)
    {
       
        
            Destroy(other.gameObject);
        SceneManager.LoadScene(Respawn);
        
    }
}
