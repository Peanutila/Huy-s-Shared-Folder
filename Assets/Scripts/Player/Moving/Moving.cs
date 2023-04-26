using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    private bool IsGrounded;
    private float gravity = -9.81f;
    private float speed = 20f;
    private float height = 3f;
    Vector3 VectorGravity = new Vector3();

    private CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        IsGrounded = controller.isGrounded;
        Debug.Log(IsGrounded);
    }
    public void ProcessMove(Vector2 input){
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime); 
        VectorGravity.y += gravity  * Time.deltaTime;
        if (IsGrounded && VectorGravity.y < 0){
            VectorGravity.y = -2;
        }
        controller.Move(VectorGravity * Time.deltaTime);
    }
    public void Jump(){
        if (IsGrounded){
            VectorGravity.y = Mathf.Sqrt(height * -3.0f * gravity);
        }
        Debug.Log("Jump");
    }
}
