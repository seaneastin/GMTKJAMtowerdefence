using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehavior : MonoBehaviour
{

    public GameUIBehavoir UI;
    public bool Gameover;
    public bool Win;
    public List<BaseTowerProjectile> towers;
    int Towersnum;
    public GameObject goblinai;
    // Start is called before the first frame update
    void Start()
    {
         Towersnum= towers.Count;
    }

    // Update is called once per frame
    void Update()
    {
        if (towers.Count <= 0)
        {
            Win = true;
        }
        if (Win)
        {
            Gameover = true;
        }
        foreach (BaseTowerProjectile tower in towers)
        {
            if(tower.getHealth() <= 0)
            {
                towers.Remove(tower);
            }

            if (Win)
            {
                
            }
        }
        if (Gameover)
        {
            UI.Gameover();
        }
    }
}
