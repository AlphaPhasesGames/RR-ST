using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage1FirstNumberFoundTrigger : MonoBehaviour
    {
        public Stage1TextManager textMan;
        public GameObject boxToRemove;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Debug.Log("This Fires");
                textMan.positionChanged = true;
                textMan.arrayPos = 4;
                boxToRemove.gameObject.SetActive(false);
           
            }
        }
    }
}
