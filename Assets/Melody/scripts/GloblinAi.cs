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
    public int DeathTimer;
    private bool Dead;
    public int Damage;

    // Start is called before the first frame update
    void Start()
    {
        globin = gameObject.GetComponent<NavMeshAgent>();
        _startingAttackTimer = AttackTimer;
        _attackTimer = _startingAttackTimer;
    }

    // Update is called once per frame
    void Update()
    {
        globin.destination = target.transform.position;
        if (Dead)
        {
            attackmode = false;
            gameObject.GetComponent<NavMeshAgent>().enabled = false;
            if(_attackTimer > 0)
            {
                _attackTimer -= Time.deltaTime;
            }
            if (_attackTimer <= 0)
            {
                GameObject.Destroy(gameObject);
            }

        }
    }
    public int getHealth()
    {
        return Health;
    }
    public void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log("I am hurt");
    }
    public void die()
    {
        _attackTimer = DeathTimer;
        Dead = true;
    }
    public void SetTarget(GameObject GloblinTarget)
    {
        target = GloblinTarget;
    }
    private void OnTriggerStay(Collider other)
    {
        if (attackmode)
        {
            if (_attackTimer <= 0)
            {
                if (other.CompareTag("Tower"))
                {
                    other.GetComponent<BaseTowerProjectile>().takeDamage(Damage);
                }
            }
            if (_attackTimer > 0)
            {
                _attackTimer -= Time.deltaTime;
            }
        }
    }
}
