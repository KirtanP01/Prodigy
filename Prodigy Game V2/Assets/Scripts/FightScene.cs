using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FightScene : MonoBehaviour
{

    public string fightScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FightZone(EnemyCreation enemyStats)
    {
        int monsterId = enemyStats.monsterId;
        string monsterName = enemyStats.name;
        int monsterAttack = enemyStats.attack;
        int monsterHealth = enemyStats.health;
        //Debug.Log("CLICK");
        SceneManager.LoadScene(fightScene);
        PlayerPrefs.SetInt("Orientation", 0);
        PlayerPrefs.SetInt("MonsterId", monsterId);


        //PlayerPrefs.SetImage("Continue", 0);
        PlayerPrefs.SetString("CurrentLevel", fightScene);//no time to implement

        PlayerPrefs.SetInt("NewFight", 1);
        
        
        PlayerPrefs.SetInt("EnemyHP", monsterHealth);
        PlayerPrefs.SetString("EmemyName", monsterName);
        PlayerPrefs.SetInt("EnemyAttack", monsterAttack);
        //PlayerPrefs.SetString("BG", fightScene);
    }

    
}
