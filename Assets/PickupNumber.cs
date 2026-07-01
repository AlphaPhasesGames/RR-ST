using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alpha.Phases.Rounding.Roundup
{
    public class PickupNumber : MonoBehaviour
    {
        public Stage1TextManager textMan;
        public bool isInRange;
        public GameObject number;
        public GameObject numberCarried;
        public int numberValueCarrying; //  we can set this in the inspector so I can use the same script for all numbers
        public Stage1NumberManager numMan;
        public GameObject shownValuedCarriedUI;

        public bool hasBeenFired;

        private void Update()
        {
            if(isInRange && !numMan.areWeCarryingNumber)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {

                    if (!numMan.textFired)
                    {
                        textMan.positionChanged = true;
                        textMan.arrayPos = 5;
                        numMan.textFired = true;
                        Debug.Log("This fires more than once?");
                    }
                    number.gameObject.SetActive(false);
                    numberCarried.gameObject.SetActive(true);
                    numMan.areWeCarryingNumber = true;
                    numMan.houseNumber = numberValueCarrying;
                    shownValuedCarriedUI.gameObject.SetActive(true);
                }
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
