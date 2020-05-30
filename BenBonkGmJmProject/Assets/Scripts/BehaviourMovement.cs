using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BehaviourMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float speed = 6f;
    public float jumpSpeed = 8f;
    public float gravity = 20.0f;

    public Vector3 moveDir = Vector3.zero;

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

            if (Input.GetKey(KeyCode.Space))
            {
                moveDir.y = jumpSpeed;

                Debug.Log("L");
            }

            

        }

        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime * 2.5f);
    }
}
