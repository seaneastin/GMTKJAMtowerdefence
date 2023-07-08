using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testmonsterdeath : MonoBehaviour
{
    public toRagdollBehavior ragdoll;
    public bool Isdead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Isdead)
        {
            ragdoll.ragdoll();
        }
    }
}
