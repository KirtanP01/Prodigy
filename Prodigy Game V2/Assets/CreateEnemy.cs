using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject imageFolder;
    void Start()
    {
        imageFolder.transform.Find("Enemy" + PlayerPrefs.GetInt("MonsterId")).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
