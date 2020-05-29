using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BehaviourMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float speed;
    public float jumpSpeed;
    public float gravity;

    public Vector3 moveDir;

    public GameObject player;

    public CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {
            moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, 0);

            if (Input.GetButton("Jump"))
            {
                moveDir.y = jumpSpeed;
            }

            moveDir.y -= gravity * Time.deltaTime;
            controller.Move(moveDir * Time.deltaTime * 2.5f);

        }
    }
}
