using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Alpha.Phases.Rounding.Roundup
{
    public class SetupStage1 : MonoBehaviour
    {

        public bool runonce;
        public bool runOnceTwice;
        public Stage1TextManager textMan;
        //public TextMeshProUGUI wages;
        public GameObject numberOnHouse1;
        public GameObject numberOnHouse2;
        public GameObject numberOnHouse3;
        public GameObject numberOnHouse4;
        public GameObject numberOnHouse5;
        public GameObject numberOnHouse6;
        public GameObject numberOnHouse7;
        public GameObject numbersOnGround;
        public Stage1NumberManager numMan;
        public Stage1WagesManager wagMan;
        public SphereCollider spherecollider1;
        public SphereCollider spherecollider2;
        public SphereCollider spherecollider3;
        public SphereCollider spherecollider4;
        public SphereCollider spherecollider5;
        public SphereCollider spherecollider6;
        public SphereCollider spherecollider7;
        public SphereCollider spherecollider8;
        public SphereCollider spherecollider9;
        public SphereCollider spherecollider10;
        public GameObject ethylTrigger;

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

                if (MainGameManager.Instance.currentTask == 2)
                {
                    numMan.numberOnletter = 11;
                    ethylTrigger.gameObject.SetActive(true);
                    spherecollider1.enabled = true;
                    spherecollider2.enabled = true;
                    spherecollider3.enabled = true;
                    spherecollider4.enabled = true;
                    spherecollider5.enabled = true;
                    spherecollider6.enabled = true;
                    spherecollider7.enabled = true;
                    spherecollider8.enabled = true;
                    spherecollider9.enabled = true;
                    spherecollider10.enabled = true;
                    numberOnHouse1.gameObject.SetActive(true);
                    numberOnHouse2.gameObject.SetActive(true);
                    numberOnHouse3.gameObject.SetActive(true);
                    numberOnHouse4.gameObject.SetActive(true);
                    numberOnHouse5.gameObject.SetActive(true);
                    numberOnHouse6.gameObject.SetActive(true);
                    numberOnHouse7.gameObject.SetActive(true);

                    numbersOnGround.gameObject.SetActive(false);
                    wagMan.wagesValue = MainGameManager.Instance.wagesCollectedMain;
                    textMan.positionChanged = true;
                    textMan.arrayPos = 8;
                }

                runonce = true;
            }
        }
    }
}