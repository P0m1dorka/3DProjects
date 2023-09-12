using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement
{
    public void Move(Rigidbody rb, float speed, float horizonta,float vertical)
    {
        rb.position += (new Vector3(horizonta,0f,vertical))*speed*Time.deltaTime;
    }
    public void Jump(Rigidbody rb, float jumpSpeed)
    {
        rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
    }

    public void Rotate(Rigidbody rb,float horizontal, float rotSpeed)
    {
        rb.transform.Rotate(0f,horizontal*rotSpeed*Time.deltaTime,0f);
        
    }
}
