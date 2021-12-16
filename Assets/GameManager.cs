using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    SceneManager scenemanager;



    public void OnCollisionEnter2D(Collider other)
    {
        if (other.tag == "Enemy") 
        {
           
        }

        void GameOver()
        {
            
            SceneManager.LoadScene(2);
        }
    }
}
   

