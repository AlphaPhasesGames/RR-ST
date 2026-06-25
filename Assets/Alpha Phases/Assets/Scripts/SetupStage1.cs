using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Alpha.Phases.Rounding.Roundup
{
    public class SetupStage1 : MonoBehaviour
    {

        public bool runonce;

        public Stage1TextManager textMan;




       // public CameraMan camera;


        private void Awake()
        {
            if (!runonce)
            {
                MainGameManager.Instance.currentStagedqwb = 1;
                MainGameManager.Instance.SaveS1S1();


                if (MainGameManager.Instance.currentTask == 1)
                {

                    textMan.positionChanged = true;
                    textMan.arrayPos = 0;
                }

                //  StartCoroutine(RemoveFlash());
                /*
                if (MainGameManager.Instance.currentTask == 2)
                {
                    taskPanal.gameObject.SetActive(true);
                    task2.gameObject.SetActive(true);
                    concept1Rock.gameObject.SetActive(true);
                    concept2RegMeta.gameObject.SetActive(true);
                    concept3Process.gameObject.SetActive(true);
                    amountOfGems.text = MainGameManager.Instance.collectedGems.ToString();
                    camera.MoveToPlayer();
                    player.gameObject.SetActive(true);
                    textMan.positionChanged = true;
                    textMan.arrayPos = 13;
                    journal.gameObject.SetActive(false);
                    wPArrow.gameObject.SetActive(false);
                    chests.gameObject.SetActive(true);
                    chestsOnMap.gameObject.SetActive(true);
                    boat.gameObject.SetActive(false);
                }

                if (MainGameManager.Instance.currentTask == 3)
                {
                    taskPanal.gameObject.SetActive(true);
                    task3.gameObject.SetActive(true);
                    concept1Rock.gameObject.SetActive(true);
                    concept2RegMeta.gameObject.SetActive(true);
                    concept3Process.gameObject.SetActive(true);
                    concept4GeoProcess.gameObject.SetActive(true);
                    camera.MoveToPlayer();
                    player.gameObject.SetActive(true);
                    textMan.positionChanged = true;
                    textMan.arrayPos = 32;
                    journal.gameObject.SetActive(false);
                    wPArrow.gameObject.SetActive(false);
                    //switches.gameObject.SetActive(false);
                    switchesOnmap.gameObject.SetActive(true);
                    boat.gameObject.SetActive(false);
                }
                runonce = true;
            }*/
            }
        }
    }
}