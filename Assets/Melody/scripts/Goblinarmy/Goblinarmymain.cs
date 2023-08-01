using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class Goblinarmymain : MonoBehaviour
{
    public int maxGoblins;
    public int minGoblins;
    public int startingGlobks;
    private int _maxGoblins;
    private GameObject _target;
    private GameObject _player;
    List<GameObject> _globlins = new List<GameObject>();
    public GameObject goblinLeader;
    [SerializeField]
    private bool _goblinattack;
    public GameObject goblinSpawn;
    public GameObject[] goblin;
    public GameObject target;
    int g;


    // Start is called before the first frame update
    void Start()
    {
        g = 0;
        _target = _player;
        _maxGoblins = startingGlobks;
        for (int i = 0; i <= _maxGoblins; i++)
        {
            GameObject thisgloblin;
            thisgloblin = GameObject.Instantiate(goblin[g], goblinSpawn.transform.position, goblinSpawn.transform.rotation);
            _globlins.Add(thisgloblin);
            thisgloblin = _globlins[i];
            thisgloblin.gameObject.GetComponent<GloblinAi>().target = goblinLeader;
        }

        _maxGoblins = maxGoblins;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1"))
        {
            for (int i = _globlins.Count; i <= _maxGoblins; i++)
            {
                g = UnityEngine.Random.Range(0, goblin.Count());
                GameObject thisgloblin;
                thisgloblin = GameObject.Instantiate(goblin[g], goblinSpawn.transform.position, goblinSpawn.transform.rotation);
                _globlins.Add(thisgloblin);
                thisgloblin = _globlins[i];
                thisgloblin.gameObject.GetComponent<GloblinAi>().target = goblinLeader;
            }
        }
        foreach(GameObject goblin in _globlins)
        {
            if (goblin.GetComponent<GloblinAi>().getHealth() <= 0)
            {
                _globlins.Remove(goblin);
                goblin.GetComponent<GloblinAi>().die();
            }
        }
        if (_target != null)
        {
            if (_target.GetComponent<BaseTowerProjectile>().getHealth() <= 0)
            {
                StopGoblinAttack(goblinLeader);
            }
        }
    }
    public void StartGoblinAttack(GameObject tower)
    {
        _target = tower;
        for (int i = 0; i <= _globlins.Count - 1; i++)
        {
            _globlins[i].GetComponent<GloblinAi>().attackmode = true;

            _globlins[i].GetComponent<GloblinAi>().SetTarget(tower);
        }
    }
    public void StopGoblinAttack(GameObject Player)
    {
        _target = Player;
        for (int i = 0; i <= _globlins.Count - 1; i++)
        {
            _globlins[i].GetComponent<GloblinAi>().attackmode = false;
            _globlins[i].GetComponent<GloblinAi>().SetTarget(Player);
        }
    }
}
