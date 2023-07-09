using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GloblinAi : MonoBehaviour
{
    public int Health;
    public GameObject target;
    private NavMeshAgent globin;
    [HideInInspector]
    public bool attackmode = false;
    public int AttackTimer;
    private float _startingAttackTimer;
    private float _attackTimer;

    // Start is called before the first frame update
    void Start()
    {
        globin = gameObject.GetComponent<NavMeshAgent>();
        _startingAttackTimer = AttackTimer;
    }

    // Update is called once per frame
    void Update()
    {
        globin.destination = target.transform.position;
    }
    public int getHealth()
    {
        return Health;
    }
    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
    private void die()
    {

    }
    public void SetTarget(GameObject GloblinTarget)
    {
        target = GloblinTarget;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Tower"))
        {

        }
    }
}
