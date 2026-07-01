using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage1WageReducer : MonoBehaviour
    {
        public Stage1WagesManager wages;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                wages.wagesValue -= 1;

            }
        }
    }
}
