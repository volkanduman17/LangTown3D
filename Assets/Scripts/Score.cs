using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    int playerScore=0;
    public Animator animDans;
    public GameObject kamera;
    public GameObject youWinCanvas;
    public GameObject youLostCanvas;

    void Update()
    {
        scoreText.text = playerScore.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "trueOption")
        {
            playerScore++;
            Debug.Log("dogru");
        }
        else if (other.tag=="falseOption")
        {
            Debug.Log("yanlis");
        }
        else if (other.tag=="finish")
        {

            gameObject.GetComponent<runnerMovement>().forwardSpeed = 0f;
            gameObject.GetComponent<runnerMovement>().isRunning = false;
            if (playerScore>=5)
            {
                gameObject.GetComponent<runnerMovement>().anim.SetBool("isRun", false);
                gameObject.GetComponent<runnerMovement>().anim.SetBool("isWin", true);
                transform.DOLocalRotate(new Vector3(0, 180, 0), 4f);
                kamera.transform.parent = null;
                youWinCanvas.SetActive(true);



            }
            if (playerScore < 5)
            {
                gameObject.GetComponent<runnerMovement>().anim.SetBool("isRun", false);
                gameObject.GetComponent<runnerMovement>().anim.SetBool("isLost", true);
                transform.DOLocalRotate(new Vector3(0, 180, 0), 4f);
                kamera.transform.parent = null;
                youLostCanvas.SetActive(true);
            }

           //transform.DORotate(new Vector3 (0,0,0), 3f,[RotateMode mode=RotateMode.Fast]);
            



        }
    }
        
    

}
