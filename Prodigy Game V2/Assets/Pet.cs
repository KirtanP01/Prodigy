using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Pet : MonoBehaviour
{
    //attack, health, speed, crit damage, crit rate, image, type
    public string name;
    public int attack;
    public int health;
    public int speed;
    public int critDmg;
    public int critRate;
    public int xp;
    public int level;
    public string type;
    //public GameObject template;

    public void createPet(string name, int health, int attack, int speed, int critDmg, int critRate, string type)
    {
        this.name = name;
        this.health = health;
        this.attack = attack;
        this.speed = speed;
        this.critDmg = critDmg;
        this.critRate = critRate;
        this.type = type;

        
    }
}