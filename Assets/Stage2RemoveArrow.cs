using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage2RemoveArrow : MonoBehaviour
    {
        // public int DoorstepValue;
        public bool hitOnce;
        public Stage2TextManager textMan;
        public GameObject arrow;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Newspaper"))
            {
                if (!hitOnce)
                {
                    textMan.positionChanged = true;
                    textMan.arrayPos = 6;
                    arrow.gameObject.SetActive(false);
                    hitOnce = true;
                }

            }
        }
    }
}
