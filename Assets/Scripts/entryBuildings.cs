using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class entryBuildings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag=="grocery")
        {
            SceneManager.LoadScene("CardFruits");
        }

        if (other.tag == "colors")
        {
            SceneManager.LoadScene("CardColors");
        }

        if (other.tag == "school")
        {
            SceneManager.LoadScene("CardSchool");
        }
    }
}
