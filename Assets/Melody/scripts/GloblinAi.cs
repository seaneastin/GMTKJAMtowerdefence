using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GloblinAi : MonoBehaviour
{
    public int Health;
    public GameObject target;
    private NavMeshAgent globin;

    // Start is called before the first frame update
    void Start()
    {
        globin= gameObject.GetComponent<NavMeshAgent>();
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
}
