using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextCardButton : MonoBehaviour
{
   

    public void MoveRight() // Butona bastýðýmýzda çalýþacak fonksiyon
    {
        if (transform.position.x<136)
        {
            // Kamerayý saða kaydýr
            transform.position = new Vector3(transform.position.x + 7.5f, transform.position.y, transform.position.z);
        }   
       
    }
    public void MoveLeft() // Butona bastýðýmýzda çalýþacak fonksiyon
    {
        if (transform.position.x>1)
        {

            // Kamerayý sola kaydýr
            transform.position = new Vector3(transform.position.x - 7.5f, transform.position.y, transform.position.z);
        }
    }
    
    public void playRunner()
    {
        SceneManager.LoadScene("fruitRunnerScene");
    }

}

