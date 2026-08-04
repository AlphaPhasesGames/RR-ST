using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage2Trigger1 : MonoBehaviour
    {
        public BoxCollider trigger1;
        public Stage2TextManager textMan;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                textMan.positionChanged = true;
                textMan.arrayPos = 3;
                trigger1.enabled = false;
            }
        }
    }
}
