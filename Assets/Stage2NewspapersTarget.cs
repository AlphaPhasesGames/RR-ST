using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage2NewspapersTarget : MonoBehaviour
    {
       // public int DoorstepValue;
        public bool hitOnce;
        public Stage2TextManager textMan;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Newspaper"))
            {
                if (!hitOnce)
                {
                    textMan.positionChanged = true;
                    textMan.arrayPos = 6;
                    hitOnce = true;
                }

            }
        }


    }
}
