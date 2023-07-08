using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toRagdollBehavior : MonoBehaviour
{
    Animator animator;
    CharacterController characterController;
    public bool timeractive = true;
    float timer = 20;
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
        if (timeractive & Isragdoll)
        {
            if (timer <= 0)
            {
                Destroy();
            }
            timer -= Time.deltaTime;
        }

    }
    public void ragdoll()
    {
        if (characterController)
        {
            characterController.enabled = false;
        }
        
        if (animator)
        {
            animator.enabled = false;
        }

        Isragdoll = true;
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }

    private void FixedUpdate()
    {



    }
}
