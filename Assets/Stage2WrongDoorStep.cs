using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage2WrongDoorStep : MonoBehaviour
    {
        // public int DoorstepValue;
        public Stage2TextManager textMan;
        public AudioSource wrongSFX;
        public int arrayPosition;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Newspaper"))
            {
                    wrongSFX.Play();
                    textMan.ResetBools();
                    textMan.positionChanged = true;
                    textMan.arrayPos = arrayPosition;  
            }
        }


    }
}
