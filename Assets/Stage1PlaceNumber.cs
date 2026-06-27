using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage1PlaceNumber : MonoBehaviour
    {
        public bool isInRange;
        public GameObject carriedNumber;
        public GameObject houseNumber;
        public int houseNumberHeld;
        public Stage1NumberManager numMan;
        public PickupNumber placeNum;
        private void Update()
        {
            if (isInRange && numMan.areWeCarryingNumber)
            {
                if (Input.GetKeyDown(KeyCode.E) && numMan.houseNumber == placeNum.numberValueCarrying)                
                {
                    houseNumber.gameObject.SetActive(true);
                    carriedNumber.gameObject.SetActive(false);
                    numMan.areWeCarryingNumber = false;
                    numMan.houseNumber = 0;
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
