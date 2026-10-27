using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
using UnityEngine.SceneManagement;
namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage1TextManager : MonoBehaviour
    {
        public SimpleRobotMovement playerCont;
        public JournalOpenButton journalOpen;
        public bool hasScrolled;
        public GameObject currentTextSection;
        public int arrayPos;
        public int maxLengthArray;
        public int minLengthArray = 0;
        public GameObject taskBar;
        public GameObject task1Text;
        public GameObject task2Text;
        public GameObject task3Text;
        public bool positionChanged;
        public Button journalButton;
        public bool runThrice;

        public Camera playerCam;
        public Camera streetCam;


        public GameObject[] modelArray;
        public GameObject textPanal;

        public GameObject numberLine;

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

        public GameObject letterFront;
        public GameObject text13;
        public GameObject text18;
        public GameObject text15;

        public GameObject wagesSide;
        public GameObject FinalWages;

        public Button crossButton1;
        public GameObject depotArrow;
        private void Awake()
        {
            forwardButton.onClick.AddListener(ProgressTextForward);
            backwardsButton.onClick.AddListener(ProgressTextBack);
            journalButton.onClick.AddListener(SpeakJournal1);
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
                positionChanged = false;

                // Deactivate all text objects, activate only the current one
                for (int i = 0; i < modelArray.Length; i++)
                {
                    modelArray[i].SetActive(i == arrayPos);
                }

                if (MainGameManager.Instance.autoTTS)
                {
                    IntroTTSSpeak(arrayPos + 1);
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
                        LOLSDK.Instance.SubmitProgress(0, 0, 100);
                        submitOnce = true;
                    }
                    playerCont.moveSpeed = 0;
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    StartCoroutine(DelayTextButton());
                   
                    Debug.Log("Array pos 0 runs");
                    break;

                case 1:
                    playerCam.gameObject.SetActive(false);
                    streetCam.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(true);
                     break;
                case 2:
                    numberLine.gameObject.SetActive(true);
                    taskBar.gameObject.SetActive(true);
                    task1Text.gameObject.SetActive(true);
                    break;
                case 3:
                    playerCam.gameObject.SetActive(true);
                    streetCam.gameObject.SetActive(false);
                    StartCoroutine(EnableCross());
                    break;
                case 4:
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardButton.gameObject.SetActive(false);
                    playerCont.moveSpeed = 0;
                    StartCoroutine(EnableCross());
                    break;
                case 5:
                    textPanal.gameObject.SetActive(true);
                    playerCont.moveSpeed = 0;
                    depotArrow.gameObject.SetActive(true);
                    StartCoroutine(EnableCross());
                    break;
                case 6:
                    textPanal.gameObject.SetActive(true);
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    break;
                case 7:
                    depotArrow.gameObject.SetActive(false);
                    textPanal.gameObject.SetActive(true);
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    break;
                case 8:
                    textPanal.gameObject.SetActive(true);
                    crossButton1.gameObject.SetActive(false);
                    StartCoroutine(DelayTextButton());
                    task1Text.gameObject.SetActive(false);
                    task2Text.gameObject.SetActive(true);
                    playerCont.moveSpeed = 0;
                    {
                        LOLSDK.Instance.SubmitProgress(0, 25, 100);
                        submitTwice = true;
                    }
                    break;
                   
                case 9:
                    letterFront.gameObject.SetActive(true);
                    text13.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(true);
                    break;
                case 10:
                    //journalOpen.OpenMap();

                    break;
                case 11:
                    StartCoroutine(EnableCross());
                    break;
                case 12:
                    text13.gameObject.SetActive(false);
                    text18.gameObject.SetActive(true);
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    playerCont.moveSpeed = 0;
                    StartCoroutine(EnableCross());
                    break;
                case 13:
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    StartCoroutine(EnableCross());
                    break;                    
               case 14:
                    // This is free atm
                  
                    break;
               case 15:
                    backwardsButton.gameObject.SetActive(false);
                    textPanal.gameObject.SetActive(true);
                    playerCont.moveSpeed = 0;
                    StartCoroutine(EnableCross());
                    break;
               case 16:
                    textPanal.gameObject.SetActive(true);
                    StartCoroutine(EnableCross());
                    break;                    
              case 17:
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    DisableCross();

                    if (!submitThrice)
                    {
                        LOLSDK.Instance.SubmitProgress(0, 30, 100);
                        submitThrice = true;
                    }
                    task2Text.gameObject.SetActive(false);
                    task3Text.gameObject.SetActive(true);
                    StartCoroutine(DelayTextButton());
                    break;                 
              case 18:
                    backwardsButton.gameObject.SetActive(true);
                    StartCoroutine(DelayTextButton());
                    break;                   
              case 19: // rock cycle steps -
                    wagesSide.gameObject.SetActive(false);
                    FinalWages.gameObject.SetActive(true);
                    numberLine.gameObject.SetActive(false);

                    break;
              case 20:
                    backwardsButton.gameObject.SetActive(false);
                    break;
              case 21:
                    FinalWages.gameObject.SetActive(false);
                    MainGameManager.Instance.ResetTask();
                    if (!submitFourth)
                    {
                        LOLSDK.Instance.SubmitProgress(0, 40, 100);
                        submitFourth = true;
                    }
                    StartCoroutine(ChangeScene());
                    break;
              case 22:
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
                if (arrayPos != 3 && arrayPos != 4 && arrayPos != 5 && arrayPos != 6 && arrayPos != 7 && arrayPos != 11 && arrayPos != 12 && arrayPos != 13 && arrayPos != 15 && arrayPos != 16 && arrayPos != 19 && arrayPos != 20 && arrayPos != 21)
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


        public void SpeakJournal1()
        {
            LOLSDK.Instance.SpeakText("stage1Journal");
        }
        public void DisableCross()
        {

            crossButton1.gameObject.SetActive(false);
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

            yield return new WaitForSeconds(4.5f);
          
            forwardButton.gameObject.SetActive(true);

            Debug.Log("This coRoutine Runs");

        }


        public IEnumerator MoveToBlankInvislbePanalUnit17()
        {
            yield return new WaitForSeconds(4);
            //playerMoveScript.enabled = true;
            textPanal.gameObject.SetActive(false);
            arrayPos = 22;
            //playerCont.moveSpeed = 5;
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
            yield return new WaitForSeconds(2);

            textPanal.gameObject.SetActive(true);

            arrayPos = 0;
            positionChanged = true;      // <-- ensure Update processes arrayPos 0
                                         // textBools[0] = true;      // <-- remove this so case 0 will run
            Debug.Log("This start coRoutine Runs");
        }

        public IEnumerator EnableCross()
        {
            yield return new WaitForSeconds(4.5f);
            crossButton1.gameObject.SetActive(true);
            Debug.Log("This start coRoutine Runs");
        }


        public void CrossButton()
        {
            textPanal.gameObject.SetActive(false);

            positionChanged = false;
            arrayPos = 20;

            playerCont.moveSpeed = 8;
            crossButton1.gameObject.SetActive(false);
        }


        public IEnumerator ChangeScene()
        {
            yield return new WaitForSeconds(4);
            SceneManager.LoadScene("Stage 2 newspapers");
        }

    }
}

