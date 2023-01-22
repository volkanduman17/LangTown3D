using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class returnHomeBtn : MonoBehaviour
{
    

    public void ReturnHome()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
