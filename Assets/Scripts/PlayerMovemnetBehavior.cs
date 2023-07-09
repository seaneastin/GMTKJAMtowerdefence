using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemnetBehavior : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnRate = 1.0f;
    CharacterController controller = null;
    Animator animator = null;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (controller.enabled)
        {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

            controller.SimpleMove(transform.forward * movement.z * speed);
            transform.Rotate(transform.up, movement.x * turnRate);
            animator.SetFloat("Speed", movement.z * speed);
            print(movement.z * speed);
        }
    }
}
