using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertest : MonoBehaviour
{
    public GameUIBehavoir UI;
    public float morale = 0;
    public float maxmorale = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UI.SetHealth(morale,maxmorale);
    }
}
