using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatasaveObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        if(FindObjectsOfType<DatasaveObject>().Length > 2)
        {
            Destroy(gameObject);
        }
    }

}
