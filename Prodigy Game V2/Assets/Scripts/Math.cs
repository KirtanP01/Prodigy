using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Math : MonoBehaviour
{

    public static Math instance;

    public Text questionText;
    public Text anwserText;

    public List<string> Questions = new List<string>();
    public List<string> Answers = new List<string>();
    //public static List<string> questionsCovered = new List<string>();


    void Start()
    {
        /*Questions.Add("2 + 2");
        Questions.Add("1 + 3");
        Questions.Add("1 + 2");
        Questions.Add("4 + 2");
        Questions.Add("3 + 3");
        Answers.Add("4");
        Answers.Add("4");
        Answers.Add("3");
        Answers.Add("6");
        Answers.Add("6");
        Questions.Add("11 + 2");
        Questions.Add("4 + 9");
        Questions.Add("7 + 5");
        Questions.Add("12 + 8");
        Questions.Add("13 + 5");
        Answers.Add("13");
        Answers.Add("13");
        Answers.Add("12");
        Answers.Add("20");
        Answers.Add("18");
        Questions.Add("6 * 2");
        Questions.Add("4 * 3");
        Questions.Add("4 * 9");
        Questions.Add("2 * 4");
        Questions.Add("8 * 6");
        Answers.Add("12");
        Answers.Add("12");
        Answers.Add("36");
        Answers.Add("8");
        Answers.Add("48");*/
    }
    public int GetTotalQuestions()
    {
        return Questions.Count;
    }
    private void Awake()
    {
        instance = this;
    }

}
