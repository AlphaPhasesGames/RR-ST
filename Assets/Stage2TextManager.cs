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

        public bool runThrice;


        public GameObject[] modelArray;
        public GameObject textPanal;
        //public ArrowPointer arrow;

        public GameObject numberLine;

        public bool panalOpen;
        public bool runOnce;
        public bool runOnce2;

        public bool submitOnce;
        public bool submitTwice;
        public Button forwardButton;
        public Button backwardsButton;

        public Button[] textButtons;
        public bool[] textBools;
/*
        public GameObject deliveryList;
        public GameObject text13;
        public GameObject text18;
        public GameObject text15;
        */
        public GameObject wagesSide;
        public GameObject FinalWages;

        public Button crossButton1;


        //public bool inventoryReadToBeOpen;

        private void Awake()
        {
            forwardButton.onClick.AddListener(ProgressTextForward);
            backwardsButton.onClick.AddListener(ProgressTextBack);

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
                    numberLine.gameObject.SetActive(true);
                    StartCoroutine(EnableCross());
                    break;
                case 3:
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
                    StartCoroutine(EnableCross());
                    break;
                case 6:
                    textPanal.gameObject.SetActive(true);
                    StartCoroutine(EnableCross());
                    break;
                case 7:
                    textPanal.gameObject.SetActive(true);
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    break;
                case 8:
                    textPanal.gameObject.SetActive(true);
                    StartCoroutine(DelayTextButton());
                    break;
                case 9:
                    wagesSide.gameObject.SetActive(false);
                    FinalWages.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(true);
                    break;
                case 10:
                    textPanal.gameObject.SetActive(true);
                    break;
                case 11:
                    textPanal.gameObject.SetActive(true);
                    StartCoroutine(EnableCross());
                    break;
                case 12:
                    //  text13.gameObject.SetActive(false);
                    //  text18.gameObject.SetActive(true);
                    FinalWages.gameObject.SetActive(false);
                    textPanal.gameObject.SetActive(true);
                    StartCoroutine(EnableCross());
                    break;
                case 13:
                    textPanal.gameObject.SetActive(false);
                   
                    break;
               

            }
        }

        public void IntroTTSSpeak(int textIndex)
        {
            string textKey = $"stage1Text{textIndex}";
            LOLSDK.Instance.SpeakText(textKey);
            Debug.Log($"stage1Text{textIndex} Button is pressed");
        }


        public void ProgressTextForward()
        {
            if (arrayPos < maxLengthArray - 1)
            {
                arrayPos++;
                positionChanged = true;
                hasScrolled = false;
                forwardButton.gameObject.SetActive(false);

                // Only run DelayTextButton if the next arrayPos is not 2
                if (arrayPos != 2 && arrayPos != 6 && arrayPos != 5 && arrayPos != 9 && arrayPos != 11 && arrayPos != 12 && arrayPos != 13 && arrayPos != 15 && arrayPos != 16 && arrayPos != 19)
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
        public void SpeakAllLitterText2()
        {
            LOLSDK.Instance.SpeakText("stage1TextAllBottlesCollected");
        }

        public void SpeakPaper1()
        {
            LOLSDK.Instance.SpeakText("stage1RCStep1");
        }

        public void SpeakPaper2()
        {
            LOLSDK.Instance.SpeakText("stage1RCStep2");
        }

        public void SpeakPaper3()
        {
            LOLSDK.Instance.SpeakText("stage1RCStep3");
        }

        public void SpeakPaper4()
        {
            LOLSDK.Instance.SpeakText("stage1RCStep4");
        }

        public void SpeakPaper5()
        {
            LOLSDK.Instance.SpeakText("stage1RCStep5");
        }

        public void SpeakPaper6()
        {
            LOLSDK.Instance.SpeakText("stage1RCStep6");
        }

        public void SpeakPaper7()
        {
            LOLSDK.Instance.SpeakText("stage1RCStep7");
        }

        public void SpeakJournal1Process()
        {
            LOLSDK.Instance.SpeakText("concept1Process");
        }

        public void SpeakJournal2GeoProcess()
        {
            LOLSDK.Instance.SpeakText("concept2GeoProcess");
        }

        public void SpeakJournal3Rock()
        {
            LOLSDK.Instance.SpeakText("concept3Rock");
        }

        public void SpeakJournal4RegMeta()
        {
            LOLSDK.Instance.SpeakText("concept4RegionalMeta");
        }

        public void ResetBools()
        {
            Array.Fill(textBools, false);
        }

        public IEnumerator DelayTextButton()
        {

            yield return new WaitForSeconds(1);

            forwardButton.gameObject.SetActive(true);

            Debug.Log("This coRoutine Runs");

        }


        public IEnumerator MoveToBlankInvislbePanalUnit17()
        {
            yield return new WaitForSeconds(7);
            //playerMoveScript.enabled = true;
            textPanal.gameObject.SetActive(false);
            arrayPos = 20;
            playerCont.moveSpeed = 5;
            Debug.Log("This start coRoutine Runs");

        }

        public IEnumerator MoveToBlankInvislbePanalUnit172()
        {
            yield return new WaitForSeconds(7);
            //playerMoveScript.enabled = true;
            textPanal.gameObject.SetActive(false);
            arrayPos = 44;
            playerCont.moveSpeed = 5;
            Debug.Log("This start coRoutine Runs");

        }


        public IEnumerator StartStage1()
        {
            yield return new WaitForSeconds(4);

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


        public void CrossButton()
        {
            textPanal.gameObject.SetActive(false);
            positionChanged = true;
            arrayPos = 13;
            playerCont.moveSpeed = 5;
            crossButton1.gameObject.SetActive(false);
        }

    }
}