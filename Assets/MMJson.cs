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
        /*public TextMeshProUGUI stage1Text3;
        public TextMeshProUGUI stage1Text4;
        public TextMeshProUGUI stage1Text5;
        public TextMeshProUGUI stage1Text6;
        public TextMeshProUGUI stage1Text7;
        public TextMeshProUGUI stage1Text8;
        public TextMeshProUGUI stage1Text9;
        public TextMeshProUGUI stage1Text10;
        public TextMeshProUGUI stage1Text11;
        public TextMeshProUGUI stage1Text12;
        public TextMeshProUGUI stage1Text13;
        public TextMeshProUGUI stage1Text14;
        public TextMeshProUGUI stage1Text15;
        public TextMeshProUGUI stage1Text16;
        public TextMeshProUGUI stage1Text17;
        public TextMeshProUGUI stage1Text18;
        public TextMeshProUGUI stage1Text19;
        public TextMeshProUGUI stage1Text20;
        public TextMeshProUGUI stage1Text21;
        public TextMeshProUGUI stage1Text22;
        public TextMeshProUGUI stage1Text23;
        public TextMeshProUGUI stage1Text24;
        public TextMeshProUGUI stage1Text25;
        public TextMeshProUGUI stage1Text26;
        public TextMeshProUGUI stage1Text27;
        public TextMeshProUGUI stage1Text28;
        public TextMeshProUGUI stage1Text29;
        public TextMeshProUGUI stage1Text30;
        public TextMeshProUGUI stage1Text31;
        public TextMeshProUGUI stage1Text32;
        public TextMeshProUGUI stage1Text33;
        public TextMeshProUGUI stage1Text34;

        public TextMeshProUGUI stigma;
        public TextMeshProUGUI stamen;

        public TextMeshProUGUI stigmaJourn;
        public TextMeshProUGUI stamenJourn;

        public TextMeshProUGUI task1;
        public TextMeshProUGUI task2;
        public TextMeshProUGUI task3;
        public TextMeshProUGUI task4;
        public TextMeshProUGUI task5;
        public TextMeshProUGUI pollinateLabel;
        public TextMeshProUGUI weedingLabel;
        public TextMeshProUGUI pruningLabel;

        public TextMeshProUGUI yesButton1;
        public TextMeshProUGUI noButton1;

        public TextMeshProUGUI yesButton2;
        public TextMeshProUGUI noButton2;

        public TextMeshProUGUI yesButton3;
        public TextMeshProUGUI noButton3;

        public TextMeshProUGUI journalTitle;
        public TextMeshProUGUI growthText;

        public TextMeshProUGUI concept1Nessecary;
        public TextMeshProUGUI concept2PollProcess;
        public TextMeshProUGUI concept3OrderStages;
        public TextMeshProUGUI concept4DiffPlantsAnim;
        */



        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;


            mmNewGame.text = defs["newGame"];
            mmContinue.text = defs["continue"];
/*
            stigmaJourn.text = defs["stigmaLabel"];
            stamenJourn.text = defs["stamenLabel"];

            task1.text = defs["stage1Task1"];
            task2.text = defs["stage1Task2"];
            task3.text = defs["stage1Task3"];
            task4.text = defs["stage1Task4"];
            task5.text = defs["stage1Task5"];

            pollinateLabel.text = defs["pollinateLabel"];
            weedingLabel.text = defs["weedingLabel"];
            pruningLabel.text = defs["pruningLabel"];

            yesButton1.text = defs["yesButton"];
            noButton1.text = defs["noButton"];

            yesButton2.text = defs["yesButton"];
            noButton2.text = defs["noButton"];

            yesButton3.text = defs["yesButton"];
            noButton3.text = defs["noButton"];

            journalTitle.text = defs["journalTitle"];
            growthText.text = defs["gDAO"];
            concept1Nessecary.text = defs["coreConcept1"];
            concept2PollProcess.text = defs["coreConcept2"];
            concept3OrderStages.text = defs["coreConcept3"];
            concept4DiffPlantsAnim.text = defs["coreConcept4"];


            stage1Text1.text = defs["stage1Text1"];
            stage1Text2.text = defs["stage1Text2"];
            stage1Text3.text = defs["stage1Text3"];
            stage1Text4.text = defs["stage1Text4"];
            stage1Text5.text = defs["stage1Text5"];
            stage1Text6.text = defs["stage1Text6"];
            stage1Text7.text = defs["stage1Text7"];
            stage1Text8.text = defs["stage1Text8"];
            stage1Text9.text = defs["stage1Text9"];
            stage1Text10.text = defs["stage1Text10"];
            stage1Text11.text = defs["stage1Text11"];
            stage1Text12.text = defs["stage1Text12"];
            stage1Text13.text = defs["stage1Text13"];
            stage1Text14.text = defs["stage1Text14"];
            stage1Text15.text = defs["stage1Text15"];
            stage1Text16.text = defs["stage1Text16"];
            stage1Text17.text = defs["stage1Text17"];
            stage1Text18.text = defs["stage1Text18"];
            stage1Text19.text = defs["stage1Text19"];
            stage1Text20.text = defs["stage1Text20"];
            stage1Text21.text = defs["stage1Text21"];
            stage1Text22.text = defs["stage1Text22"];
            stage1Text23.text = defs["stage1Text23"];
            stage1Text24.text = defs["stage1Text24"];
            stage1Text25.text = defs["stage1Text25"];
            stage1Text26.text = defs["stage1Text26"];
            stage1Text27.text = defs["stage1Text27"];
            stage1Text28.text = defs["stage1Text28"];
            stage1Text29.text = defs["stage1Text29"];
            stage1Text30.text = defs["stage1Text30"];
            stage1Text31.text = defs["stage1Text31"];
            stage1Text32.text = defs["stage1Text32"];
            stage1Text33.text = defs["stage1Text33"];
            stage1Text34.text = defs["stage1Text34"];
*/
        }

    }
}

