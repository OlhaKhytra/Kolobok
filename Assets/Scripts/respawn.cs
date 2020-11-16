using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class respawn : MonoBehaviour
{
    public int Respawn;
    [SerializeField] Transform spawnPoint;
    void OnCollisionEnter(Collision col)
    {

        if (col.transform.CompareTag("Player"))
            col.transform.position = spawnPoint.position;
      
           // SceneManager.LoadScene(Respawn);
        
        
    }
}
