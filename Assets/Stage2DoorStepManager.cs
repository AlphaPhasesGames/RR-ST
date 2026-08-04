using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage2DoorStepManager : MonoBehaviour
    {
        public int amountOfDoorsteps;
        public Stage2TextManager textMan;


        public bool runOnce;

        private void Update()
        {
            if (amountOfDoorsteps >= 5 && !runOnce)
            {
                runOnce = true;
                AddDoorstep();
            }
        }

        public void AddDoorstep()
        {
            amountOfDoorsteps++;

            if (amountOfDoorsteps >= 5)
            {
                textMan.positionChanged = true;
                textMan.arrayPos = 8;
            }
        }
    }
}