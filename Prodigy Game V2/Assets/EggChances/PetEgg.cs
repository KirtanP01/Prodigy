using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//using static System.Collections.IEnumerable;
//public interface IEnumerable<out T> : System.Collections.IEnumerable
[CreateAssetMenu(fileName = "New Item", menuName = "Pet Egg/Create New Pet Egg")]

public class PetEgg : ScriptableObject
{
    //attack, health, speed, crit damage, crit rate, image, type
    public string name;
    public int price;
    public List<PetChance> numberNames;// = new Dictionary<Pet, int>();
    
}