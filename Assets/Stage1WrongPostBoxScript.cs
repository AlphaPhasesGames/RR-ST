using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage1WrongPostBoxScript : MonoBehaviour
    {
        public bool isInRange;
        public AudioSource wrongSFX;
       // public Animator postBoxAnimation;
        public Stage1TextManager textMan;
    private void Update()
        {
            if (isInRange)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    wrongSFX.Play();
                    textMan.ResetBools();
                    textMan.positionChanged = true;
                    textMan.arrayPos = 13;
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