using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toRagdollBehavior : MonoBehaviour
{
    public GameObject character;
    Animator animator;
    CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        animator = character.GetComponent<Animator>();
        characterController = character.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ragdoll()
    {
        characterController.enabled = false;
        animator.enabled = false;
    }
}
