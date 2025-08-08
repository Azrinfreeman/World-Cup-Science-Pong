using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public System.Random rnd = new System.Random();

    public System.Random rnd2 = new System.Random();

    public System.Random rnd3 = new System.Random();
    public List<int> randomAnswer;

    public TextMeshProUGUI textQuestion;
    public TextMeshProUGUI questionTransform;
    public TextMeshProUGUI questionNumberRN;
    int questionNumberRNCount;
    public string questions;
    public int questionCount = 0;
    public int maxQuestionCount;
    int questionsNum;
    public int length;
    public int buttonNum;
    public int answers;
    public int playerInt = 0;
    public Button[] ansButton = new Button[4];
    public Button soundBtn;

    public bool hasTold = false;

    // Start is called before the first frame update
    void Start()
    {
        questionNumberRNCount = 1;
        questionCount = 0;
        /*questionsNum = rnd3.Next(0, QuestionController.instance.questionsList.Count);//

*/
        questionsNum = rnd3.Next(
            0,
            QuestionController.instance.levels[QuestionController.instance.level - 1].question.Count
        );
        Invoke("startControlling", 0.12f);
    }

    void startControlling()
    {
        //Time.timeScale = 1;
        if (transform.GetChild(0).transform.GetChild(0).transform.gameObject.activeSelf)
        {
            playerInt = 0;
            soundBtn = transform
                .GetChild(0)
                .transform.GetChild(0)
                .transform.GetChild(0)
                .transform.GetChild(1)
                .transform.GetChild(0)
                .transform.GetChild(3)
                .transform.GetComponent<Button>();
            ShowQuestion(playerInt);
            //Debug.Log("player1 is active");
        }
        else if (transform.GetChild(0).transform.GetChild(1).transform.gameObject.activeSelf)
        {
            playerInt = 1;
            soundBtn = transform
                .GetChild(0)
                .transform.GetChild(1)
                .transform.GetChild(0)
                .transform.GetChild(1)
                .transform.GetChild(0)
                .transform.GetChild(3)
                .transform.GetComponent<Button>();
            ShowQuestion(playerInt);
            //Debug.Log("player2 is active");
        }
    }

    void OnEnable()
    {
        // Invoke("startControlling", 0.12f);
    }

    public void ShowQuestion(int playerInt)
    {
        StartCoroutine(showQuest(playerInt));
    }

    IEnumerator showQuest(int playerInt)
    {
        //Timing.gameObject.SetActive(true);

        //if else level

        //question for the number
        textQuestion = transform
            .GetChild(0)
            .transform.GetChild(playerInt)
            .GetChild(0)
            .transform.GetChild(1)
            .transform.GetChild(0)
            .transform.GetChild(0)
            .GetComponent<TextMeshProUGUI>();

        questionNumberRN = transform
            .GetChild(0)
            .transform.GetChild(playerInt)
            .GetChild(0)
            .transform.GetChild(0)
            .transform.GetChild(1)
            .transform.GetChild(0)
            .GetComponent<TextMeshProUGUI>();
        questionNumberRN.text = questionNumberRNCount.ToString();

        questionsNum = rnd3.Next(
            0,
            QuestionController.instance.levels[QuestionController.instance.level - 1].question.Count
        );
        answers = questionsNum;

        //question for the number
        questions = QuestionController
            .instance.levels[QuestionController.instance.level - 1]
            .question[answers]
            .question.ToString();

        questionTransform = transform
            .GetChild(0)
            .transform.GetChild(playerInt)
            .transform.GetChild(0)
            .transform.GetChild(1)
            .transform.GetChild(0)
            .transform.GetChild(0)
            .GetComponent<TextMeshProUGUI>();
        //   Debug.Log(questionTransform);
        questionTransform.text = questions + " ";

        //assign buttons in gameobject

        ansButton[0] = transform
            .GetChild(0)
            .transform.GetChild(playerInt)
            .transform.GetChild(0)
            .transform.GetChild(1)
            .transform.GetChild(0)
            .transform.GetChild(1)
            .transform.GetChild(0) //answer btn 1
            .GetComponent<Button>();
        ansButton[1] = transform
            .GetChild(0)
            .transform.GetChild(playerInt)
            .transform.GetChild(0)
            .transform.GetChild(1)
            .transform.GetChild(0)
            .transform.GetChild(1)
            .transform.GetChild(1) //answer btn 2
            .GetComponent<Button>();
        ansButton[2] = transform
            .GetChild(0)
            .transform.GetChild(playerInt)
            .transform.GetChild(0)
            .transform.GetChild(1)
            .transform.GetChild(0)
            .transform.GetChild(2)
            .transform.GetChild(0) //answer btn 3
            .GetComponent<Button>();
        ansButton[3] = transform
            .GetChild(0)
            .transform.GetChild(playerInt)
            .transform.GetChild(0)
            .transform.GetChild(1)
            .transform.GetChild(0)
            .transform.GetChild(2)
            .transform.GetChild(1) //answer btn 4
            .GetComponent<Button>();

        //assign random answer to random buttons
        //enable the component on buttons;
        EnableAllButtons();

        if (QuestionController.instance.level < 4)
        {
            //choose which button to put answer
            buttonNum = rnd.Next(2);
            //add function to button

            for (int a = 0; a < 2; a++)
            {
                ansButton[a].onClick.RemoveAllListeners();
                ansButton[a].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "";
                Debug.Log("Clear button");
            }

            ansButton[buttonNum].onClick.RemoveAllListeners();
            ansButton[buttonNum].onClick.AddListener(() => CorrectButtonFunction());
            ansButton[buttonNum].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text =
                QuestionController
                    .instance
                    .levels[QuestionController.instance.level - 1]
                    .question[questionsNum]
                    .answer
                    .answerButton[
                    QuestionController
                        .instance
                        .levels[QuestionController.instance.level - 1]
                        .question[questionsNum]
                        .answer
                        .ansOnButton
                ] + " BETUL";

            //add play sound button to soundbtn
            soundBtn.onClick.RemoveAllListeners();
            //soundBtn.onClick.AddListener(() => PlayCorrectAnswerSound(answers));
            //add something to button child
            /*            ansButton[buttonNum].GetComponent<Image>().sprite = QuestionController
                            .instance.questionsList[answers]
                            .GetComponent<Image>()
                            .sprite;*/

            Debug.Log(
                "Jawapan:"
                    + QuestionController
                        .instance
                        .levels[QuestionController.instance.level - 1]
                        .question[questionsNum]
                        .answer
                        .answerButton[
                        QuestionController
                            .instance
                            .levels[QuestionController.instance.level - 1]
                            .question[questionsNum]
                            .answer
                            .ansOnButton
                    ]
            );
        }
        else if (QuestionController.instance.level > 4)
        {
            //choose which button to put answer
            buttonNum = rnd.Next(4);

            for (int a = 0; a < 4; a++)
            {
                ansButton[a].onClick.RemoveAllListeners();
                Debug.Log("Clear button");
            }
            //add function to button
            ansButton[buttonNum].onClick.RemoveAllListeners();
            ansButton[buttonNum].onClick.AddListener(() => CorrectButtonFunction());
            ansButton[buttonNum].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text =
                QuestionController
                    .instance
                    .levels[QuestionController.instance.level - 1]
                    .question[questionsNum]
                    .answer
                    .answerButton[
                    QuestionController
                        .instance
                        .levels[QuestionController.instance.level - 1]
                        .question[questionsNum]
                        .answer
                        .ansOnButton
                ];
            //add play sound button to soundbtn
            soundBtn.onClick.RemoveAllListeners();
            //soundBtn.onClick.AddListener(() => PlayCorrectAnswerSound(answers));
            //add something to button child
            /*ansButton[buttonNum].GetComponent<Image>().sprite = QuestionController
                    .instance.questionsList[answers]
                    .GetComponent<Image>()
                    .sprite;
                    */

            Debug.Log(
                "Jawapan:"
                    + QuestionController
                        .instance
                        .levels[QuestionController.instance.level - 1]
                        .question[questionsNum]
                        .answer
                        .answerButton[
                        QuestionController
                            .instance
                            .levels[QuestionController.instance.level - 1]
                            .question[questionsNum]
                            .answer
                            .ansOnButton
                    ]
            );
        }
        Debug.Log("questionNum: " + questionsNum);

        if (QuestionController.instance.level < 4)
        {
            length = 2;
            ansButton[2].gameObject.transform.parent.transform.gameObject.SetActive(false);
        }
        else if (QuestionController.instance.level > 4)
        {
            length = 4;
        }
        Debug.Log("buttonNum: " + buttonNum);
        for (int i = 0; i < length; i++)
        {
            Debug.Log("before i = " + i);
            if (i != buttonNum)
            {
                //the list
                int chooseRandom = rnd.Next(
                    0,
                    QuestionController
                        .instance
                        .levels[QuestionController.instance.level - 1]
                        .question
                        .Count
                );

                //if list is empty (first time)
                if (randomAnswer.Count == 0)
                {
                    while (chooseRandom == questionsNum)
                    {
                        chooseRandom = rnd.Next(
                            0,
                            QuestionController
                                .instance
                                .levels[QuestionController.instance.level - 1]
                                .question
                                .Count
                        );
                    }
                    randomAnswer.Add(chooseRandom);
                }
                else
                {
                    // check if randomnumbers are duplicated in list
                    for (int l = 0; l < randomAnswer.Count; l++)
                    {
                        //                        Debug.Log("Check");
                        while (randomAnswer[l] == chooseRandom)
                        {
                            //          Debug.Log("Duplicated");
                            //generate new number if chooseRandom already in the list
                            chooseRandom = rnd.Next(
                                0,
                                QuestionController
                                    .instance
                                    .levels[QuestionController.instance.level - 1]
                                    .question
                                    .Count
                            );
                        }
                    }
                    //check if answers is already selected from the list
                    while (chooseRandom == answers)
                    {
                        Debug.Log("Duplicated");
                        //generate new number if chooseRandom already in the list
                        chooseRandom = rnd.Next(
                            0,
                            QuestionController
                                .instance
                                .levels[QuestionController.instance.level - 1]
                                .question
                                .Count
                        );
                    }

                    //

                    randomAnswer.Add(chooseRandom);
                }
                ansButton[i].onClick.RemoveAllListeners();
                ansButton[i].onClick.AddListener(() => buttonFunction());
                /* ansButton[i].GetComponent<Image>().sprite = QuestionController
                     .instance.questionsList[chooseRandom]
                     .GetComponent<Image>()
                     .sprite;
                 */

                //button salah

                Debug.Log("i = " + i);
                ansButton[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text =
                    QuestionController
                        .instance
                        .levels[QuestionController.instance.level - 1]
                        .question[questionsNum]
                        .answer
                        .answerButton[i];
            }
        }

        if (questionCount == 0)
        {
            //play notidication sound
            if (!GameObject.Find("notification").GetComponent<AudioSource>().isPlaying)
            {
                GameObject.Find("notification").GetComponent<AudioSource>().Play();
            }
        }
        if (!hasTold)
        { //play answer sound
            yield return new WaitForSeconds(1.1f);
            if (!GameObject.Find("pilihyangbetul").GetComponent<AudioSource>().isPlaying)
            {
                GameObject.Find("pilihyangbetul").GetComponent<AudioSource>().Play();
            }
            hasTold = true;
            yield return new WaitForSeconds(2.2f);
        }
        else
        {
            yield return new WaitForSeconds(0.6f);
        }
    }

    public void disableTick()
    {
        transform
            .GetChild(0)
            .transform.GetChild(playerInt)
            .transform.GetChild(0)
            .transform.GetChild(1)
            .transform.GetChild(3)
            .GetComponent<Transform>()
            .gameObject.SetActive(false);

        transform
            .GetChild(0)
            .transform.GetChild(playerInt)
            .transform.GetChild(0)
            .transform.GetChild(1)
            .transform.GetChild(2)
            .GetComponent<Transform>()
            .gameObject.SetActive(false);
    }

    IEnumerator incorrectAnswer()
    {
        questionNumberRNCount++;

        DisableAllButtons();
        //add count to question
        questionCount++;
        Debug.Log("Incorrect");
        yield return new WaitForSeconds(0.45f);

        if (!GameObject.Find("wrong").GetComponent<AudioSource>().isPlaying)
        {
            GameObject.Find("wrong").GetComponent<AudioSource>().Play();
        }
        //display red tick
        transform
            .GetChild(0)
            .transform.GetChild(playerInt)
            .transform.GetChild(0)
            .transform.GetChild(1)
            .transform.GetChild(3)
            .GetComponent<Transform>()
            .gameObject.SetActive(true);

        yield return new WaitForSeconds(1f);
        questionNumberRN.text = questionNumberRNCount.ToString();
        //undisplay red tick
        transform
            .GetChild(0)
            .transform.GetChild(playerInt)
            .transform.GetChild(0)
            .transform.GetChild(1)
            .transform.GetChild(3)
            .GetComponent<Transform>()
            .gameObject.SetActive(false);

        yield return new WaitForSeconds(0.45f);

        if (questionCount >= maxQuestionCount)
        {
            questionCount = 0;
            questionNumberRNCount = 1;
            Managers.Game.SetState(typeof(KickOffState));
            transform.gameObject.SetActive(false);
            Managers.UI.inGameUI.gameBackButton.gameObject.SetActive(true);
        }
        else
        {
            ShowQuestion(playerInt);
        }
    }

    public void buttonFunction()
    {
        StartCoroutine(incorrectAnswer());
    }

    public void PlayCorrectAnswerSound(int answers)
    {
        Debug.Log("play sound");
        if (
            !QuestionController
                .instance.questionsList[answers]
                .GetComponent<AudioSource>()
                .isPlaying
        )
        {
            QuestionController.instance.questionsList[answers].GetComponent<AudioSource>().Play();
        }
    }

    public void CorrectButtonFunction()
    {
        StartCoroutine(roundCollected());
    }

    void DisableAllButtons()
    {
        for (int i = 0; i < ansButton.Length; i++)
        {
            ansButton[i].GetComponent<Button>().enabled = false;
        }
    }

    void EnableAllButtons()
    {
        //        Debug.Log(ansButton.Length);
        for (int i = 0; i < ansButton.Length; i++)
        {
            ansButton[i].GetComponent<Button>().enabled = true;
        }
    }

    IEnumerator roundCollected()
    {
        questionNumberRNCount++;

        DisableAllButtons();
        //disable buttons

        //add count to question
        questionCount++;
        //play correct sound
        if (GameObject.Find("rewarded").GetComponent<AudioSource>().isPlaying)
        {
            GameObject.Find("rewarded").GetComponent<AudioSource>().Stop();
        }
        if (!GameObject.Find("rewarded").GetComponent<AudioSource>().isPlaying)
        {
            GameObject.Find("rewarded").GetComponent<AudioSource>().Play();
        }
        //display tick
        transform
            .GetChild(0)
            .transform.GetChild(playerInt)
            .transform.GetChild(0)
            .transform.GetChild(1)
            .transform.GetChild(2)
            .GetComponent<Transform>()
            .gameObject.SetActive(true);

        CollectionController.instance.addStars(5, playerInt);
        //CollectionController.instance.addRounds(playerInt, 1);
        //roundTransform.GetComponent<Animator>().Play("collected");

        yield return new WaitForSeconds(0.45f);
        //play sound
        /*        if (!GameObject.Find("collected").GetComponent<AudioSource>().isPlaying)
                {
                    GameObject.Find("collected").GetComponent<AudioSource>().Play();
                }
          */yield return new WaitForSeconds(0.35f);

        //roundTransform.GetComponent<Animator>().Play("afterCollected");

        //destroy and remove the questions from the list
        QuestionController
            .instance.levels[QuestionController.instance.level - 1]
            .question.RemoveAt(questionsNum);

        //Destroy(gameObject);

        yield return new WaitForSeconds(1f);

        questionNumberRN.text = questionNumberRNCount.ToString();
        //erased text again

        if (questionCount >= maxQuestionCount)
        {
            //undisplay tick
            transform
                .GetChild(0)
                .transform.GetChild(playerInt)
                .transform.GetChild(0)
                .transform.GetChild(1)
                .transform.GetChild(2)
                .GetComponent<Transform>()
                .gameObject.SetActive(false);

            questionCount = 0;
            hasTold = false;
            questionNumberRNCount = 1;
            Managers.Game.SetState(typeof(KickOffState));
            transform.gameObject.SetActive(false);
            Managers.UI.inGameUI.gameBackButton.gameObject.SetActive(true);
        }
        else
        {
            //undisplay tick
            transform
                .GetChild(0)
                .transform.GetChild(playerInt)
                .transform.GetChild(0)
                .transform.GetChild(1)
                .transform.GetChild(2)
                .GetComponent<Transform>()
                .gameObject.SetActive(false);

            ShowQuestion(playerInt);
        }
    }

    // Update is called once per frame
    void Update() { }
}
