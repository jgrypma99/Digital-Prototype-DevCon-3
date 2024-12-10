using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    public Rigidbody RB;
    public Vector3 inputVector;
    bool canMove;
    // Start is called before the first frame update
    void Start()
    {
        canMove = true;
        RB = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {      
            inputVector = new Vector3(Input.GetAxis("Horizontal"), 0, 0);        
    }

    void FixedUpdate()
    {
        if (canMove == true)
        {
            RB.AddForce(inputVector * 50);
        }
    }

    // Disable input when colliding with another gameobject
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Walls"))
        {
            canMove = true;
        }
        else
        {
            canMove = false;
        }
    }
}
