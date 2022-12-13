using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vittu : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.layer == 7) {
            SceneManager.LoadScene(1);
            
        }
         if(other.gameObject.layer == 8) {
            SceneManager.LoadScene(2);
            
        }
        if(other.gameObject.layer == 9) {
            SceneManager.LoadScene(3);
            
        }        
        
    }
}