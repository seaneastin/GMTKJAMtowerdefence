using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUIBehavoir : MonoBehaviour
{
    public GameObject gameUI;
    public GameObject youlost;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Loadlevel(int levelid)
    {
        SceneManager.LoadScene(levelid);
    }    

    public void Gameover()
    {
        gameUI.SetActive(false);
        youlost.SetActive(true);
    }    


    public void Newgame()
    {
        Loadlevel(1);
    }

    public void Leavegame()
    {
        Loadlevel(1);
    }

}
