using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage1House20PostDeliverySpot : MonoBehaviour
    {
        public bool isInRange;
        public Animator postBoxAnimation;
        public Stage1NumberManager numMan;
        public Stage1TextManager textMan;
        public Stage1WagesManager wages;
        private void Update()
        {
            if (isInRange)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (numMan.numberOnletter == 15)
                    {
                        textMan.positionChanged = true;
                        textMan.arrayPos = 15;
                        textMan.text18.gameObject.SetActive(false);
                        textMan.text15.gameObject.SetActive(true);
                        numMan.numberOnletter = 14;
                        wages.wagesValue += 2;
                        postBoxAnimation.SetBool("letterDelivered", true);
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
