using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage1House30Script : MonoBehaviour
    {
        public Stage1TextManager textMan;
        public Stage1WagesManager wages;
        public bool isInRange;
        public GameObject carriedNumber;
        public GameObject houseNumber;
        public int houseNumberHeld;
        public Stage1NumberManager numMan;
        public PickupNumber placeNum;
        public BoxCollider houseColliderToHide;
        public GameObject uiNumberToShow;
        public GameObject shownValuedCarriedUI;
        public bool hasFired;
        public GameObject numArrow1;
        public GameObject numArrow2;
        public GameObject numArrow3;
        public GameObject numArrow4;
        public GameObject numArrow5;
        public GameObject numArrow6;
        public AudioSource rightSFX;
        public AudioSource wrongSFX;
        private void Update()
        {
            if (isInRange && numMan.areWeCarryingNumber)
            {
                if (Input.GetKeyDown(KeyCode.E) && numMan.houseNumber == placeNum.numberValueCarrying)
                {
                    if (!hasFired)
                    {
                        textMan.positionChanged = true;
                        textMan.arrayPos = 7;
                        hasFired = true;
                    }
                    rightSFX.Play();
                    houseNumber.gameObject.SetActive(true);
                    carriedNumber.gameObject.SetActive(false);
                    numMan.areWeCarryingNumber = false;
                    numMan.houseNumber = 0;
                    uiNumberToShow.gameObject.SetActive(true);
                    shownValuedCarriedUI.gameObject.SetActive(false);
                    houseColliderToHide.gameObject.SetActive(false);
                    numMan.housesVisited++;
                    wages.wagesValue += 3;
                    numArrow1.gameObject.SetActive(true);
                    numArrow2.gameObject.SetActive(true);
                    numArrow3.gameObject.SetActive(true);
                    numArrow4.gameObject.SetActive(true);
                    numArrow5.gameObject.SetActive(true);
                    numArrow6.gameObject.SetActive(true);
                }
            }

            if (isInRange && numMan.areWeCarryingNumber && numMan.houseNumber != placeNum.numberValueCarrying)
            {
                wrongSFX.Play();
                textMan.ResetBools();
                textMan.positionChanged = true;
                textMan.arrayPos = 6;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                isInRange = true;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                isInRange = false;
            }
        }
    }
}
