using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alpha.Phases.Rounding.Roundup
{
    public class PickupNumber : MonoBehaviour
    {
        public bool isInRange;
        public GameObject number;
        public GameObject numberCarried;
        public int numberValueCarrying; //  we can set this in the inspector so I can use the same script for all numbers
        public Stage1NumberManager numMan;
        private void Update()
        {
            if(isInRange && !numMan.areWeCarryingNumber)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    number.gameObject.SetActive(false);
                    numberCarried.gameObject.SetActive(true);
                    numMan.areWeCarryingNumber = true;
                    numMan.houseNumber = numberValueCarrying;
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
