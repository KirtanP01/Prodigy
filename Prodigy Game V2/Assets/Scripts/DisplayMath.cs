using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayMath : MonoBehaviour
{

    public static List<int> questionsCovered = new List<int>();
    public static int currentQuestion;
    public static int Score = 0;
    private int attack = 10;
    private int damage = 5;

    //public Random rnd = new Random();

    void Start()
    {
        //getNextQuestion(1);
        int index = getRandom();
        Debug.Log("Question count " + Math.instance.Questions.Count);
        if (index < Math.instance.Questions.Count)
        {
            Math.instance.questionText.text = Math.instance.Questions[index];
            questionsCovered.Add(index);
            currentQuestion = index;
        }
        Debug.Log("Displayed Question in Start");
    }


    void Update()
    {

    }

    private int getRandom()
    {
        int index;
        while (true)
        {
            index = Random.Range(0, Math.instance.GetTotalQuestions()-1);
            Debug.Log(index);
            if (!questionsCovered.Contains(index))
            {
                break;
            }
        }
        return index;
    }

    IEnumerator CoCheckAnwser()
    {
        //yield return new WaitForSeconds(2);

        if (Math.instance.anwserText.text == Math.instance.Answers[currentQuestion])
        {
            Debug.Log("Correct, attack");
            Score += attack;
            HPstats.instance.HeroAttacks();
            HPstats.instance.EnemyAttacks();
            Debug.Log("-10 monster health");
            SceneManager.LoadScene("FightScene", LoadSceneMode.Single);
            Math.instance.anwserText.text = "";
        }
        else
        {
            Debug.Log("Wrong, take damage");
            if (Score <= 0)
            {
                Score -= damage;
            }
            //Run Enemy attack animation
            HPstats.instance.EnemyAttacks();
            Debug.Log("-10 enemy health");
            SceneManager.LoadScene("FightScene", LoadSceneMode.Single);
            Math.instance.anwserText.text = "";
        }

        yield return new WaitForSeconds(1);

        if (Score >= 100)
        {
            //Display Game Won!! Congratulations
            Debug.Log("Game Won!! Congratulations");
            //End Game
        }
        else if (Score < 100 && questionsCovered.Count >= 15)
        {
            //Display "Game Lost"
            Debug.Log("Game Lost");
            //End Game
        }
        else
        {
            getNextQuestion();
        }
    }


    public void checkAnwser()
    {
        StartCoroutine(CoCheckAnwser());
    }

    private void getNextQuestion(int No = 0)
    {
        int index;
        if (No == 1)
        {
            index = 1;
            Debug.Log("Index 1");
        }
        else
        {
            index = getRandom();
        }

        if (index < Math.instance.Questions.Count)
        {
            Math.instance.questionText.text = Math.instance.Questions[index];
            questionsCovered.Add(index);
            currentQuestion = index;
        }
    }
}
