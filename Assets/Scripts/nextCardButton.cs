using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextCardButton : MonoBehaviour
{
   

    public void MoveRight() // Butona bast���m�zda �al��acak fonksiyon
    {
        if (transform.position.x<136)
        {
            // Kameray� sa�a kayd�r
            transform.position = new Vector3(transform.position.x + 7.5f, transform.position.y, transform.position.z);
        }   
       
    }
    public void MoveLeft() // Butona bast���m�zda �al��acak fonksiyon
    {
        if (transform.position.x>1)
        {

            // Kameray� sola kayd�r
            transform.position = new Vector3(transform.position.x - 7.5f, transform.position.y, transform.position.z);
        }
    }
    
    public void playRunner()
    {
        SceneManager.LoadScene("fruitRunnerScene");
    }

}

