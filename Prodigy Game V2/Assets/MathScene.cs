using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MathScene : MonoBehaviour
{
    public void DisplayMath()
    {
        Debug.Log("WTF");
        SceneManager.LoadScene("Math Scene");
    }
}
