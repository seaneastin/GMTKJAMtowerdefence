using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    CharacterController projectile;
    private Vector3 forward;
    private bool fired;
    // Start is called before the first frame update
    void Start()
    {
            projectile = gameObject.GetComponent<CharacterController>();
            forward = gameObject.transform.forward.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        projectile.Move(forward * Time.deltaTime);
    }
}
