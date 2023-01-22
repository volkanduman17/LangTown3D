using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public float rotationSpeed = 20f;
    void Update()
    {
        transform.Rotate(0,0,rotationSpeed * Time.deltaTime);

    }
}
