using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartButton : MonoBehaviour
{
    
    public void restartFruit()
    {
        SceneManager.LoadScene("fruitRunnerScene");
    }

    public void restartColors()
    {
        SceneManager.LoadScene("colorsRunnerScene");
    }

    public void restartSchool()
    {
        SceneManager.LoadScene("schoolRunnerScene");
    }

}
