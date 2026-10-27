using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using TMPro;

namespace Alpha.Phases.Geoquest
{
    public class MMJson : MonoBehaviour
    {
        public TextMeshProUGUI mmNewGame;
        public TextMeshProUGUI mmContinue;
        public TextMeshProUGUI autoReadTTS;



        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;


            mmNewGame.text = defs["newGame"];
            mmContinue.text = defs["continue"];
            autoReadTTS.text = defs["autoTTS"];
        }

    }
}

