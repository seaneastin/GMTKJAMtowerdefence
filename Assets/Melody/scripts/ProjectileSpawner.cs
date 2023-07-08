using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    private bool _targetset;
    private Collider target;
    public GameObject projectile;
    private bool _fired;
    private bool _fire;
    // Start is called before the first frame update
    void Start()
    {
        _targetset = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (_targetset)
        {
            if (_fire)
            {
                gameObject.transform.LookAt(target.transform);
                GameObject.Instantiate(projectile, gameObject.transform.position, gameObject.transform.rotation);
            }
        }
    }
    public void OnTriggerStay(Collider other)
    {
        if (!_targetset)
        {
            Debug.Log("die");
            target = other;
            _targetset = true;
            _fire = true;
        }

    }
    public void OnTriggerExit(Collider other)
    {
        if (_targetset)
        {
            if (other = target)
            {
                _targetset = false;
                _fire = false;
            }
        }
    }
}
