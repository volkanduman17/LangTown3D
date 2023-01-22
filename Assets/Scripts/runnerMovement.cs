using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runnerMovement : MonoBehaviour
{
    [SerializeField] public float forwardSpeed;
    [SerializeField] public float movementSpeed;
    public bool isRunning;
    public Animator anim;
    Vector3 firstPos, endPos;

    void Start()
    {
        anim = GetComponent<Animator>();
        isRunning = true;
    }

    void Update()
    {
        if (isRunning==true)
        {
            anim.SetBool("isRun", true);
            transform.position += Vector3.forward * (Time.deltaTime * forwardSpeed);
            HorizontalMovement();
        }
    }

    public void HorizontalMovement()
    {
        if (Input.GetMouseButtonDown(0))
        {
            firstPos = Input.mousePosition;
        }

        else if (Input.GetMouseButton(0))
        {
            endPos = Input.mousePosition;
            float farkX = endPos.x - firstPos.x;
            transform.Translate(farkX * Time.deltaTime * movementSpeed, 0, 0);
        }

        else if (Input.GetMouseButtonUp(0))
        {
            firstPos = Vector3.zero;
            endPos = Vector3.zero;
        }

    }




}
