﻿using System.Collections;
using System.Collections.Generic;
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
    private bool _goblinattack;
    public GameObject goblinSpawn;
    public GameObject goblin;


    // Start is called before the first frame update
    void Start()
    {
        _target = _player;
        _maxGoblins = startingGlobks;
        for (int i = 0; i <= _maxGoblins; i++)
        {
            GameObject thisgloblin;
            thisgloblin = GameObject.Instantiate(goblin, goblinSpawn.transform.position, goblinSpawn.transform.rotation);
            _globlins.Add(thisgloblin);
            thisgloblin = _globlins[i];
            thisgloblin.gameObject.GetComponent<GloblinAi>().target = goblinLeader;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}