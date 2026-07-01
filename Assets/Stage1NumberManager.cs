using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage1NumberManager : MonoBehaviour
    {
        public bool areWeCarryingNumber;
        public int houseNumber;
        public int housesVisited;
        public Stage1TextManager textMan;
        public bool hasFired;
        public bool textFired;
        public SphereCollider spherecollider1;
        public SphereCollider spherecollider2;
        public SphereCollider spherecollider3;
        public SphereCollider spherecollider4;
        public SphereCollider spherecollider5;
        public SphereCollider spherecollider6;
        public SphereCollider spherecollider7;
        public SphereCollider spherecollider8;
        public SphereCollider spherecollider9;
        public SphereCollider spherecollider10;
        public GameObject ethylTrigger;
        public int numberOnletter;


        private void Update()
        {
            if (hasFired)
            {
                return;
            }

            if(housesVisited > 6 && !hasFired)
            {
                numberOnletter = 11;
                spherecollider1.enabled = true;
                spherecollider2.enabled = true;
                spherecollider3.enabled = true;
                spherecollider4.enabled = true;
                spherecollider5.enabled = true;
                spherecollider6.enabled = true;
                spherecollider7.enabled = true;
                spherecollider8.enabled = true;
                spherecollider9.enabled = true;
                spherecollider10.enabled = true;

                textMan.positionChanged = true;
                textMan.arrayPos = 8;
                ethylTrigger.gameObject.SetActive(true);
                hasFired = true;
            }
        }

    }
}
