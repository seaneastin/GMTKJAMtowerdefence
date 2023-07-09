using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameUIBehavoir : MonoBehaviour
{
    public GameObject gameUI;
    public GameObject youlost;
    public Slider healthbar;
    public Text moraletext;
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
        Cursor.visible = true;
    }    

    public void Newgame()
    {
        Loadlevel(3);
    }

    public void Leavegame()
    {
        Loadlevel(0);
    }

    public void SetHealth(int health)
    {
        healthbar.value = health;
        moraletext.text = health + "/";
    }

}
