using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    private bool _targetset;
    private Collider target;
    public GameObject projectile;
    private bool _fired;
    private bool _fire;
    public int time;
    private float _timer;
    private float _originaltime;
    // Start is called before the first frame update
    void Start()
    {
        _targetset = false;
        _originaltime = time;
        _timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (target.GetComponent<GloblinAi>().getHealth() <= 0 || target == null)
        {
            _targetset = false;
        }
        if(_timer < 0)
        {
            _timer = 0;
        }
        if (_timer == 0)
        {
            _timer = _originaltime;
            if (_targetset)
            {
                if (_fire)
                {
                    gameObject.transform.LookAt(target.transform);
                    GameObject.Instantiate(projectile, gameObject.transform.position, gameObject.transform.rotation);
                }
            }
        }
        if (_timer != 0 || time > 0)
        {
            _timer -= Time.deltaTime;
        }
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Goblin"))
        {
            if (!_targetset)
            {
                Debug.Log("die");
                target = other;
                _targetset = true;
                _fire = true;
            }
        }

    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Goblin"))
        {
            if (_targetset)
            {
                if (other == target)
                {
                    _targetset = false;
                    _fire = false;
                }
            }
        }
    }
}
