using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toRagdollBehavior : MonoBehaviour
{
    Animator animator;
    CharacterController characterController;
    public bool timeractive = true;
    float timer = 600;
    bool Isragdoll = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        characterController = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
  
    }
    public void ragdoll()
    {
        characterController.enabled = false;
        animator.enabled = false;
        Isragdoll = true;
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }

    private void FixedUpdate()
    {
        if (timeractive & Isragdoll)
        {
            if (timer <= 0)
            {
                Destroy();
            }
            timer = timer - 1;
        }


    }
}
