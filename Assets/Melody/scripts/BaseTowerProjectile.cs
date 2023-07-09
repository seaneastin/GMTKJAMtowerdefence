using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTowerProjectile : MonoBehaviour
{
    public int Hp;
    private int _hp;
    private int _maxHp;
    public GameObject projectile;
    public SphereCollider triger;
    private bool _fire;
    private GameObject _cube;
    // Start is called before the first frame update
    void Start()
    {
        _hp = Hp;
        _maxHp = Hp;
        triger = gameObject.GetComponent<SphereCollider>();
        _cube = gameObject.transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void takeDamage(int Damage)
    {
        _hp -= Damage;
    }
}