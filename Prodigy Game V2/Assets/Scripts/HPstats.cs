using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPstats : MonoBehaviour
{

    public static HPstats instance;
    public GameObject HpFolder;
    public GameObject MsgObj;

    public static int HeroHP = 100;
    public static int EnemyHP = 50;
    public static int EnemyDmg = 10;
    public static string EnemyName;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("NewFight") == 1)
        {
            HeroHP = 100;
            EnemyHP = PlayerPrefs.GetInt("EnemyHP");
            EnemyName = PlayerPrefs.GetString("EmemyName");
            EnemyDmg = PlayerPrefs.GetInt("EnemyAttack");


            PlayerPrefs.SetInt("NewFight", 0);

        }

        if(EnemyHP <= 0)
        {
            MsgObj.GetComponent<Text>().text = "You win";
            EnemyHP = 0;
        }
        else if(HeroHP <= 0)
        {
            MsgObj.GetComponent<Text>().text = "You lose";

        }
        HpFolder.transform.Find("EnemyName").GetComponent<Text>().text = EnemyName;
        HpFolder.transform.Find("HeroHealth").GetComponent<Text>().text = "Hero Health: " + HeroHP;
        HpFolder.transform.Find("EnemyHealth").GetComponent<Text>().text = "Enemy Health: " + EnemyHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        instance = this;

    }

    public void HeroAttacks()
    {
        EnemyHP -= 20;
    }

    public void EnemyAttacks()
    {
        HeroHP -= EnemyDmg;
    }
}
