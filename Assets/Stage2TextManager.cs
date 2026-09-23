using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;

namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage2TextManager : MonoBehaviour
    {
        public SimpleRobotMovement playerCont;
        public bool hasScrolled;
        public GameObject currentTextSection;
        public int arrayPos;
        public int maxLengthArray;
        public int minLengthArray = 0;
        public bool positionChanged;
        public GameObject barriers;
        public GameObject city2;
        public GameObject compass;
        public bool runThrice;
        public NewsPaperThrow newsPaper;
        public Animator fadeToBlack;
        public GameObject fadeBlack;
        public GameObject[] modelArray;
        public GameObject textPanal;
        public GameObject arrow;
        public GameObject numLine1;
        public GameObject numLine2;
       // public GameObject numberLine;

        public bool panalOpen;
        public bool runOnce;
        public bool runOnce2;

        public bool submitOnce;
        public bool submitTwice;
        public bool submitThrice;
        public bool submitFourth;

        public Button forwardButton;
        public Button backwardsButton;

        public Button[] textButtons;
        public bool[] textBools;

        public Button journalButton1;
        public Button journalButton2;

        public GameObject task1;
        public GameObject task2;
        public GameObject task3;

        public GameObject wagesSide;
        public GameObject FinalWages;
        public GameObject FinalWages2;

        public Button crossButton1;


        //public bool inventoryReadToBeOpen;

        private void Awake()
        {
            forwardButton.onClick.AddListener(ProgressTextForward);
            backwardsButton.onClick.AddListener(ProgressTextBack);
            journalButton1.onClick.AddListener(SpeakJournal1);
            journalButton2.onClick.AddListener(SpeakJournal2);
            crossButton1.onClick.AddListener(CrossButton);


            for (int i = 0; i < textButtons.Length; i++)
            {
                int index = i + 1;  // Adjust index to match textButton number
                textButtons[i].onClick.AddListener(() => IntroTTSSpeak(index));
            }
            if (MainGameManager.Instance.currentTask < 1)
            {
                StartCoroutine(StartStage1());
            }


        }

        // Start is called before the first frame update
        void Start()
        {
            maxLengthArray = modelArray.Length;
            textBools = new bool[maxLengthArray];
        }

        void Update()
        {


            // Only process if the position has changed
            if (positionChanged)
            {
                positionChanged = false; // Reset flag after processing


                // Deactivate all text objects, activate only the current one
                for (int i = 0; i < modelArray.Length; i++)
                {
                    modelArray[i].SetActive(i == arrayPos);
                }

                // Handle the current array position if not yet processed
                if (!textBools[arrayPos])
                {
                    HandleArrayPosActions();
                    textBools[arrayPos] = true;
                }
            }
        }

        private void HandleArrayPosActions()
        {
            switch (arrayPos)
            {
                case 0:
                    if (!submitOnce)
                    {
                        LOLSDK.Instance.SubmitProgress(0, 50 , 100);
                        submitOnce = true;
                    }
                    playerCont.moveSpeed = 0;
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    StartCoroutine(DelayTextButton());

                    Debug.Log("Array pos 0 runs");
                    break;

                case 1:
                    backwardsButton.gameObject.SetActive(true);
                    break;
                case 2:
                    //numberLine.gameObject.SetActive(true);
                    StartCoroutine(EnableCross());
                    break;
                case 3:
                    arrow.gameObject.SetActive(false);
                    backwardsButton.gameObject.SetActive(false);
                    textPanal.gameObject.SetActive(true);
                    playerCont.moveSpeed = 0;
                    StartCoroutine(DelayTextButton());
                    break;
                case 4:
                    backwardsButton.gameObject.SetActive(true);
                    StartCoroutine(DelayTextButton());
                    break;
                case 5:
                    textPanal.gameObject.SetActive(true);
                    playerCont.moveSpeed = 5;
                    newsPaper.enabled = true;
                    StartCoroutine(EnableCross());
                    break;
                case 6:
                    backwardsButton.gameObject.SetActive(false);
                    textPanal.gameObject.SetActive(true);
                    StartCoroutine(EnableCross());
                    break;
                case 7:
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    break;

                case 8:
                    backwardsButton.gameObject.SetActive(false);
                    textPanal.gameObject.SetActive(true);
                    task1.gameObject.SetActive(false);
                    task2.gameObject.SetActive(true);
                    DisableCross();
                    StartCoroutine(DelayTextButton());
                    break;
                case 9:
                    wagesSide.gameObject.SetActive(false);
                    FinalWages.gameObject.SetActive(true);
                    DisableCross();
                    backwardsButton.gameObject.SetActive(true);
                    if (!submitTwice)
                    {
                        LOLSDK.Instance.SubmitProgress(0, 70, 100);
                        submitOnce = true;
                    }
                    break;
                case 10:
                    backwardsButton.gameObject.SetActive(false);
                    forwardButton.gameObject.SetActive(false);

                    ResetBools();
                    textPanal.gameObject.SetActive(true);
                    StartCoroutine(EnableCross());
                    break;
                case 11:
                    task2.gameObject.SetActive(false);
                    task1.gameObject.SetActive(true);
                    textPanal.gameObject.SetActive(true);
                    FinalWages.gameObject.SetActive(false);
                    city2.gameObject.SetActive(true);
                    barriers.gameObject.SetActive(false);
                    compass.gameObject.SetActive(true);
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    break;
                case 12:
                    //  text13.gameObject.SetActive(false);
                    //  text18.gameObject.SetActive(true);
                    playerCont.moveSpeed = 0;
                    textPanal.gameObject.SetActive(true);
                    numLine1.gameObject.SetActive(false);
                    numLine2.gameObject.SetActive(true);
                    DisableCross();
                    if (!submitThrice)
                    {
                        LOLSDK.Instance.SubmitProgress(0, 80, 100);
                        submitThrice = true;
                    }
                    StartCoroutine(DelayTextButton());
                    break;
                case 13:
                  
                   
                    break;
                case 14:
                 

                    break;
                case 15:
                    StartCoroutine(EnableCross());

                    break;
                case 16:
                    wagesSide.gameObject.SetActive(false);
                    FinalWages.gameObject.SetActive(true);
                    textPanal.gameObject.SetActive(true);
                    task1.gameObject.SetActive(false);
                    task3.gameObject.SetActive(true);
                    break;
                case 17:
                    textPanal.gameObject.SetActive(true);
                    FinalWages.gameObject.SetActive(false);
                    StartCoroutine(FadeBlack());
                    if (!submitFourth)
                    {
                        LOLSDK.Instance.SubmitProgress(0, 100, 100);
                        LOLSDK.Instance.CompleteGame();


                        submitFourth = true;
                    }
                    break;
                case 18:
                    textPanal.gameObject.SetActive(false);

                    break;

            }
        }

        public void IntroTTSSpeak(int textIndex)
        {
            string textKey = $"stage2Text{textIndex}";
            LOLSDK.Instance.SpeakText(textKey);
            Debug.Log($"stage2Text{textIndex} Button is pressed");
        }


        public void ProgressTextForward()
        {
            // Position 10 is failure feedback.
            // It must NEVER progress manually into position 11.
            if (arrayPos == 10)
            {
                forwardButton.gameObject.SetActive(false);
                return;
            }

            if (arrayPos < maxLengthArray - 1)
            {
                arrayPos++;
                positionChanged = true;
                hasScrolled = false;
                forwardButton.gameObject.SetActive(false);

                // Only run DelayTextButton if the next arrayPos is not 2
                if (arrayPos != 2 && arrayPos != 6 && arrayPos != 5 && arrayPos != 9 && arrayPos != 10 && arrayPos != 11 && arrayPos != 15 && arrayPos != 16 && arrayPos != 19)
                {
                    StartCoroutine(DelayTextButton());
                }
            }
        }


        public void ProgressTextBack()
        {

            if (arrayPos > minLengthArray)
            {
                arrayPos--;
                positionChanged = true; // Mark position as changed
                hasScrolled = false;
                Array.Fill(textBools, false);
            }
        }

        public void ResetPositionFlags()
        {
            Array.Fill(textBools, false); // Reset all boolean flags for text
            positionChanged = true;       // Mark position as changed for Update() processing
        }


        private void SpeakText(string textKey)
        {
            LOLSDK.Instance.SpeakText(textKey);
        }

        public void ResetBools()
        {
            Array.Fill(textBools, false);
        }

        public void SpeakJournal1()
        {
            LOLSDK.Instance.SpeakText("stage2Journal1");
        }

        public void SpeakJournal2()
        {
            LOLSDK.Instance.SpeakText("stage2Journal2");
        }

        public IEnumerator DelayTextButton()
        {

            yield return new WaitForSeconds(4.5f);

            forwardButton.gameObject.SetActive(true);

            Debug.Log("This coRoutine Runs");

        }


        public IEnumerator MoveToBlankInvislbePanalUnit17()
        {
            yield return new WaitForSeconds(7);
            //playerMoveScript.enabled = true;
            textPanal.gameObject.SetActive(false);
            arrayPos = 20;
            playerCont.moveSpeed = 8;
            Debug.Log("This start coRoutine Runs");

        }

        public IEnumerator MoveToBlankInvislbePanalUnit172()
        {
            yield return new WaitForSeconds(7);
            //playerMoveScript.enabled = true;
            textPanal.gameObject.SetActive(false);
            arrayPos = 44;
            playerCont.moveSpeed = 8;
            Debug.Log("This start coRoutine Runs");

        }


        public IEnumerator StartStage1()
        {
            yield return new WaitForSeconds(1);

            textPanal.gameObject.SetActive(true);

            arrayPos = 0;
            positionChanged = true;      // <-- ensure Update processes arrayPos 0
                                         // textBools[0] = true;      // <-- remove this so case 0 will run
            Debug.Log("This start coRoutine Runs");
        }

        public IEnumerator EnableCross()
        {
            yield return new WaitForSeconds(6);
            crossButton1.gameObject.SetActive(true);
            Debug.Log("This start coRoutine Runs");
        }
        public void DisableCross()
        {

            crossButton1.gameObject.SetActive(false);
        }

        public void CrossButton()
        {
            textPanal.gameObject.SetActive(false);
            positionChanged = true;
            arrayPos = 18;
            playerCont.moveSpeed = 8;
            crossButton1.gameObject.SetActive(false);
        }
         public IEnumerator FadeBlack()
        {
            yield return new WaitForSeconds(5);
            fadeBlack.gameObject.SetActive(true);
            fadeToBlack.SetBool("Fade", true);
        }
    }
}