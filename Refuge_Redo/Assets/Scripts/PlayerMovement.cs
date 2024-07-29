using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController char_controller;

    public float speed = 5f;
    public float rot_speed = 360f;
    public float gravity = -9.8f;

    private Vector3 vel;

    private void Start()
    {
        vel = Vector3.zero;
    }

    void Update()
    {
        if (char_controller.isGrounded && vel.y < 0f)
        {
            vel.y = 0f;
        }

        float hori_input = Input.GetAxisRaw("Horizontal");
        float vert_input = Input.GetAxisRaw("Vertical");

        if(vert_input != 0)
        {
            Vector3 move_dir = vert_input * transform.forward;
            char_controller.Move(move_dir.normalized * speed * Time.deltaTime);
        }

        if(hori_input != 0)
        {
            transform.Rotate(new Vector3(0f, hori_input * rot_speed * Time.deltaTime, 0f));
        }

        //do gravity
        vel.y += gravity * Time.deltaTime;
        char_controller.Move(vel * Time.deltaTime);
    }
}
