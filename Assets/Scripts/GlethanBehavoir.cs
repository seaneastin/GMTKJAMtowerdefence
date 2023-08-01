using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlethanBehavoir : MonoBehaviour
{
    public Goblinarmymain army1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Attack(GameObject target)
    {
        Debug.LogError(target);
        army1.StartGoblinAttack(target);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Fire"))
        {
            Debug.Log("if you see this yay");
            Attack(other.transform.parent.gameObject);
        }
    }
    public void takeDamage()
    {
        army1.playertookdamage();
    }
}
