using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage1PostDelieverSpot : MonoBehaviour
    {
        public bool isInRange;
        public Animator postBoxAnimation;
        public Stage1NumberManager numMan;
        public Stage1TextManager textMan;
        public Stage1WagesManager wages;
       // public GameObject ethylTrigger;
        private void Update()
        {
            if (isInRange)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (numMan.numberOnletter == 11)
                    {
                        textMan.positionChanged = true;
                        textMan.arrayPos = 12;
                        numMan.numberOnletter = 15;
                        postBoxAnimation.SetBool("letterDelivered", true);
                        wages.wagesValue += 2;
                       // ethylTrigger.gameObject.SetActive(true);
                    }

                    else if (numMan.numberOnletter == 14)
                    {
                        textMan.positionChanged = true;
                        textMan.arrayPos = 17;
                        wages.wagesValue += 2;
                        //postBoxAnimation.SetBool("letterDelivered", true);
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
