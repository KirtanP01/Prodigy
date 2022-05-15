using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetManager : MonoBehaviour
{
    public static PetManager Instance;
    public static bool firstTime = true;
    public List<GameObject> Pets = new List<GameObject>();
    public GameObject template;

    void Awake()
    {
        if(firstTime)
        {
            firstTime = false;
            Instance = this;
        }
        
    }
    public int CalculateChanges(PetEgg petEgg)
    {
        int totalchances = 0;
        foreach (var pet in petEgg.numberNames)
        {
            Debug.Log(pet.pet.name);
            totalchances += pet.chance;
            //Debug.Log(pet);

        }
        return totalchances;
    }

    public void SpawnPet(PetEgg petEgg)
    {

        int totalchance = CalculateChanges(petEgg);
        
        Debug.Log(totalchance);
        int chance = Random.Range(1, totalchance + 1);

        //PetBase petGet;

        foreach (var pet in petEgg.numberNames)
        {
            //Debug.Log(pet.Key);
            //Debug.Log(pet.Value);
            
            
            Debug.Log(pet.chance);

            if(chance-pet.chance <= 0)
            {
                //petGet = pet.pet;
                Debug.Log(pet.pet);
                GameObject petToAdd = Instantiate(template, gameObject.transform);

                petToAdd.GetComponent<Pet>().createPet(pet.pet.name, pet.pet.health, pet.pet.attack, pet.pet.speed, pet.pet.critDmg, pet.pet.critRate, pet.pet.type);
                //Pet pet =
                Add(petToAdd);
                break;
            }
            chance -= pet.chance;
            

        }
        //Debug.Log(petGet.name);

    }

    public void Add(GameObject pet)
    {
        Pets.Add(pet);
        //ListItems();
    }
    public void Remove(GameObject pet)
    {
        Pets.Remove(pet);
        //ListItems();
    }

    
}
