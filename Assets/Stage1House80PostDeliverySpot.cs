using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage1House80PostDeliverySpot : MonoBehaviour
    {
        public bool isInRange;

        public Stage1NumberManager numMan;
        public Stage1TextManager textMan;
        public Stage1WagesManager wages;

        public AudioSource WrongSFX;
        public AudioSource correctSFX;

        private bool deliveryCompleted;

        private void Update()
        {
            if (isInRange)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    // Correct delivery
                    if (numMan.numberOnletter == 78 && !deliveryCompleted)
                    {
                        deliveryCompleted = true;

                        correctSFX.Play();

                        textMan.positionChanged = true;
                        textMan.arrayPos = 17;

                        textMan.text18.gameObject.SetActive(false);
                        textMan.text15.gameObject.SetActive(true);

                        wages.wagesValue += 2;
                    }

                    // Wrong delivery
                    else if (numMan.numberOnletter != 78 && !deliveryCompleted)
                    {
                        textMan.ResetBools();

                        WrongSFX.Play();

                        textMan.positionChanged = true;
                        textMan.arrayPos = 13;
                    }
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