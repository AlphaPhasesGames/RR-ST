using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using TMPro;
namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage2LangMan : MonoBehaviour
    {
        public TextMeshProUGUI stage1Text1;
        public TextMeshProUGUI stage1Text2;
        public TextMeshProUGUI stage1Text3;
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


        public TextMeshProUGUI deliverySign1;
        public TextMeshProUGUI deliverySign2;
        public TextMeshProUGUI deliverySign3;
        public TextMeshProUGUI deliverySign4;
        public TextMeshProUGUI deliverySign5;
        public TextMeshProUGUI deliverySign6;
        public TextMeshProUGUI deliverySign7;
        public TextMeshProUGUI deliverySign8;
        public TextMeshProUGUI deliverySign9;
        public TextMeshProUGUI deliverySign10;

        public TextMeshProUGUI deliverySign11;
        public TextMeshProUGUI deliverySign12;
        public TextMeshProUGUI deliverySign13;
        public TextMeshProUGUI deliverySign14;
        public TextMeshProUGUI deliverySign15;
        public TextMeshProUGUI deliverySign16;
        public TextMeshProUGUI deliverySign17;
        public TextMeshProUGUI deliverySign18;
        public TextMeshProUGUI deliverySign19;
        public TextMeshProUGUI deliverySign20;

        public TextMeshProUGUI deliveryAddresses;

        public TextMeshProUGUI journalPage1;
        public TextMeshProUGUI journalPage2;


        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;


            stage1Text1.text = defs["stage2Text1"];
            stage1Text2.text = defs["stage2Text2"];
            stage1Text3.text = defs["stage2Text3"];
            stage1Text4.text = defs["stage2Text4"];
            stage1Text5.text = defs["stage2Text5"];
            stage1Text6.text = defs["stage2Text6"];
            stage1Text7.text = defs["stage2Text7"];
            stage1Text8.text = defs["stage2Text8"];
            stage1Text9.text = defs["stage2Text9"];
            stage1Text10.text = defs["stage2Text10"];
            stage1Text11.text = defs["stage2Text11"];
            stage1Text12.text = defs["stage2Text12"];
            stage1Text13.text = defs["stage2Text13"];
            stage1Text14.text = defs["stage2Text14"];
            stage1Text15.text = defs["stage2Text15"];
            stage1Text16.text = defs["stage2Text16"];
            stage1Text17.text = defs["stage2Text17"];
            stage1Text18.text = defs["stage2Text18"];

            deliverySign1.text = defs["stage2BuildingName"];
            deliverySign2.text = defs["stage2BuildingName"];
            deliverySign3.text = defs["stage2BuildingName"];
            deliverySign4.text = defs["stage2BuildingName"];
            deliverySign5.text = defs["stage2BuildingName"];
            deliverySign6.text = defs["stage2BuildingName"];
            deliverySign7.text = defs["stage2BuildingName"];
            deliverySign8.text = defs["stage2BuildingName"];
            deliverySign9.text = defs["stage2BuildingName"];
            deliverySign10.text = defs["stage2BuildingName"];

            deliverySign11.text = defs["stage2BuildingName"];
            deliverySign12.text = defs["stage2BuildingName"];
            deliverySign13.text = defs["stage2BuildingName"];
            deliverySign14.text = defs["stage2BuildingName"];
            deliverySign15.text = defs["stage2BuildingName"];
            deliverySign16.text = defs["stage2BuildingName"];
            deliverySign17.text = defs["stage2BuildingName"];
            deliverySign18.text = defs["stage2BuildingName"];
            deliverySign19.text = defs["stage2BuildingName"];
            deliverySign20.text = defs["stage2BuildingName"];

            journalPage1.text = defs["stage2Journal1"];
            journalPage2.text = defs["stage2Journal2"];

            deliveryAddresses.text = defs["deliveryZoneStage2"];
        }

    }
}
