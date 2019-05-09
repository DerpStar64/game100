using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}


public class PlayerMovement1 : MonoBehaviour
{
    public float speed;
    public Boundary boundary;

    void FixedUpdate()
    {
        

        float moveHorizontal = Input.GetAxis("Horizontal");
        

        Vector3 movement = new Vector3(moveHorizontal, 0.0f);
        GetComponent<Rigidbody>().velocity = movement * speed;
    }
}