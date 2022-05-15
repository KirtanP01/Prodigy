using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Pet/Create New Pet")]

public class PetBase : ScriptableObject
{
    //attack, health, speed, crit damage, crit rate, image, type
    public string name;
    public int attack;
    public int health;
    public int speed;
    public int critDmg;
    public int critRate;
    public string type;
}