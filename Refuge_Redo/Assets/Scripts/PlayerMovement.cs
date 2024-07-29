using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController char_controller;
    public Transform cam;
    public Transform ground_check;


    public float speed = 5f;
    public float turn_smooth_time = 0.1f;
    public float gravity = -9.8f;
    public float ground_dist = 0.4f;
    public LayerMask ground_mask;


    private float turn_smooth_vel;
    private Vector3 vel;
    private bool is_grounded;

    private void Start()
    {
        vel = Vector3.zero;

        //Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        is_grounded = Physics.CheckSphere(ground_check.position, ground_dist, ground_mask);

        if (is_grounded && vel.y < 0f)
        {
            vel.y = 0f;
        }

        float hori_input = Input.GetAxisRaw("Horizontal");
        float vert_input = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(hori_input, 0f, vert_input).normalized;

        if(dir.magnitude >= 0.1f)
        {
            float target_angle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg + cam.eulerAngles.y;

            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, target_angle, ref turn_smooth_vel, turn_smooth_time);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 move_dir = Quaternion.Euler(0f, angle, 0f) * Vector3.forward;

            

            char_controller.Move(move_dir.normalized * speed * Time.deltaTime);
        }

        //do gravity
        vel.y += gravity * Time.deltaTime;

        //char_controller.Move(vel * Time.deltaTime);
    }
}
