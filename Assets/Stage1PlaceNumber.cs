using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage1PlaceNumber : MonoBehaviour
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
                    houseNumber.gameObject.SetActive(true);
                    carriedNumber.gameObject.SetActive(false);
                    numMan.areWeCarryingNumber = false;
                    numMan.houseNumber = 0;
                    uiNumberToShow.gameObject.SetActive(true);
                    shownValuedCarriedUI.gameObject.SetActive(false);
                    houseColliderToHide.gameObject.SetActive(false);
                    numMan.housesVisited++;
                    wages.wagesValue += 3;
                }
            }

            if (isInRange && numMan.areWeCarryingNumber && numMan.houseNumber != placeNum.numberValueCarrying)
            {
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
