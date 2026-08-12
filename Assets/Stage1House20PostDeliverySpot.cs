using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage1House20PostDeliverySpot : MonoBehaviour
    {
        public bool isInRange;
       // public Animator postBoxAnimation;
        public Stage1NumberManager numMan;
        public Stage1TextManager textMan;
        public Stage1WagesManager wages;
        public AudioSource WrongSFX;
        public AudioSource correctSFX;
        private void Update()
        {
            if (isInRange)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (numMan.numberOnletter == 55)
                    {
                        correctSFX.Play();
                        textMan.positionChanged = true;
                        textMan.arrayPos = 15;
                        wages.wagesValue += 2;
                        textMan.text18.gameObject.SetActive(false);
                        textMan.text15.gameObject.SetActive(true);
                        numMan.numberOnletter = 78;
                        wages.wagesValue += 2;
                       // postBoxAnimation.SetBool("letterDelivered", true);
                    }

                    else if (numMan.numberOnletter != 55)
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
