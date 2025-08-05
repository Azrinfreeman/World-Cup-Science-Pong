using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestionController : MonoBehaviour
{
    public static QuestionController instance;
    public int level;
    public List<Level> levels;
    public List<Transform> questionsList;

    void Awake()
    {
        instance = this;
    }

    public void setlevel(int levels)
    {
        level = levels;
        if (level == 1)
        {
            for (int i = 0; i < GameObject.Find("QuestionList-" + level).transform.childCount; i++)
            {
                questionsList.Add(GameObject.Find("QuestionList-" + level).transform.GetChild(i));
            }
            Managers.UI.inGameUI.fences[0].transform.gameObject.SetActive(true);
            Managers.UI.inGameUI.fences[1].transform.gameObject.SetActive(false);
            Managers.UI.inGameUI.fences[2].transform.gameObject.SetActive(false);
        }
        else if (level == 2)
        {
            for (int i = 0; i < GameObject.Find("QuestionList-" + level).transform.childCount; i++)
            {
                questionsList.Add(GameObject.Find("QuestionList-" + level).transform.GetChild(i));
            }

            Managers.UI.inGameUI.fences[0].transform.gameObject.SetActive(false);
            Managers.UI.inGameUI.fences[1].transform.gameObject.SetActive(true);
            Managers.UI.inGameUI.fences[2].transform.gameObject.SetActive(false);
        }
        else if (level == 3)
        {
            for (int i = 0; i < GameObject.Find("QuestionList-" + level).transform.childCount; i++)
            {
                questionsList.Add(GameObject.Find("QuestionList-" + level).transform.GetChild(i));
            }

            Managers.UI.inGameUI.fences[0].transform.gameObject.SetActive(false);
            Managers.UI.inGameUI.fences[1].transform.gameObject.SetActive(false);
            Managers.UI.inGameUI.fences[2].transform.gameObject.SetActive(true);
        }
        else if (level == 4)
        {
            for (int i = 0; i < GameObject.Find("QuestionList-" + level).transform.childCount; i++)
            {
                questionsList.Add(GameObject.Find("QuestionList-" + level).transform.GetChild(i));
            }

            Managers.UI.inGameUI.fences[0].transform.gameObject.SetActive(false);
            Managers.UI.inGameUI.fences[1].transform.gameObject.SetActive(false);
            Managers.UI.inGameUI.fences[2].transform.gameObject.SetActive(true);
        }

        Managers.UI.inGameUI.levelChoices.transform.gameObject.SetActive(false);
        Managers.UI.inGameUI.PlayButton.GetComponent<Transform>().gameObject.SetActive(true);
    }

    public void setlevelSains(int levels)
    {
        level = levels;
        if (level == 1)
        {
            for (int i = 0; i < GameObject.Find("QuestionList-" + level).transform.childCount; i++)
            {
                questionsList.Add(GameObject.Find("QuestionList-" + level).transform.GetChild(i));
                Debug.Log(
                    GameObject.Find("QuestionList-" + level).transform.GetChild(i).transform.name
                );

                for (
                    int l = 0;
                    l < GameObject.Find("QuestionList-" + level).transform.GetChild(i).childCount;
                    l++
                ) { }
            }
            Managers.UI.inGameUI.fences[0].transform.gameObject.SetActive(true);
            Managers.UI.inGameUI.fences[1].transform.gameObject.SetActive(false);
            Managers.UI.inGameUI.fences[2].transform.gameObject.SetActive(false);
        }
        else if (level == 2)
        {
            for (int i = 0; i < GameObject.Find("QuestionList-" + level).transform.childCount; i++)
            {
                questionsList.Add(GameObject.Find("QuestionList-" + level).transform.GetChild(i));
            }

            Managers.UI.inGameUI.fences[0].transform.gameObject.SetActive(false);
            Managers.UI.inGameUI.fences[1].transform.gameObject.SetActive(true);
            Managers.UI.inGameUI.fences[2].transform.gameObject.SetActive(false);
        }
        else if (level == 3)
        {
            for (int i = 0; i < GameObject.Find("QuestionList-" + level).transform.childCount; i++)
            {
                questionsList.Add(GameObject.Find("QuestionList-" + level).transform.GetChild(i));
            }

            Managers.UI.inGameUI.fences[0].transform.gameObject.SetActive(false);
            Managers.UI.inGameUI.fences[1].transform.gameObject.SetActive(false);
            Managers.UI.inGameUI.fences[2].transform.gameObject.SetActive(true);
        }
        else if (level == 4)
        {
            for (int i = 0; i < GameObject.Find("QuestionList-" + level).transform.childCount; i++)
            {
                questionsList.Add(GameObject.Find("QuestionList-" + level).transform.GetChild(i));
            }

            Managers.UI.inGameUI.fences[0].transform.gameObject.SetActive(false);
            Managers.UI.inGameUI.fences[1].transform.gameObject.SetActive(false);
            Managers.UI.inGameUI.fences[2].transform.gameObject.SetActive(true);
        }

        Managers.UI.inGameUI.levelChoices.transform.gameObject.SetActive(false);
        Managers.UI.inGameUI.PlayButton.GetComponent<Transform>().gameObject.SetActive(true);
    }

    // Start is called before the first frame update
    void Start() { }

    [System.Serializable]
    public class Level
    {
        public List<QuestionsAndAnswer> question;
    }

    [System.Serializable]
    public class QuestionsAndAnswer
    {
        public String question;

        public Answer answer;
    }

    [System.Serializable]
    public class Answer
    {
        public List<String> answerButton;
    }

    // Update is called once per frame
    void Update() { }
}
