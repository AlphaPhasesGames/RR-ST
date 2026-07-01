using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage1WagesManager : MonoBehaviour
    {
        [Header("Wages")]
        public int wagesValue; // The real wages, between 10 and 20

        [Header("Display")]
        public TextMeshProUGUI onScreenValue;
        public TextMeshProUGUI onScreenValue2;
        public Stage1TextManager textMan;
        [Header("Player Answer UI")]
        public Slider wagesSlider;
        public TMP_InputField wagesInput;
        public Button submitButton;

        private int playerAnswer;

        private void Start()
        {
            wagesSlider.minValue = 10;
            wagesSlider.maxValue = 100;
            wagesSlider.wholeNumbers = true;

            wagesSlider.onValueChanged.AddListener(OnSliderChanged);
            wagesInput.onValueChanged.AddListener(OnInputChanged);
            submitButton.onClick.AddListener(SubmitAnswer);

            //UpdateWagesText();
        }

        private void Update()
        {
            UpdateWagesText();
        }

        private void UpdateWagesText()
        {
            onScreenValue.text = wagesValue.ToString();
            onScreenValue2.text = wagesValue.ToString();
        }

        private void OnSliderChanged(float value)
        {
            playerAnswer = Mathf.RoundToInt(value);
            wagesInput.text = playerAnswer.ToString();
        }

        private void OnInputChanged(string value)
        {
            if (int.TryParse(value, out int result))
            {
                result = Mathf.Clamp(result, 10, 100);

                playerAnswer = result;
                wagesSlider.value = result;
            }
        }

        private void SubmitAnswer()
        {
            int correctRoundedAnswer = Mathf.RoundToInt(wagesValue / 10f) * 10;

            if (playerAnswer == correctRoundedAnswer)
            {
                textMan.ResetBools();
                textMan.positionChanged = true;
                textMan.arrayPos = 21;
                Debug.Log("Correct wages rounding!");
                // Continue to next part / end stage
            }
            else
            {
                textMan.positionChanged = true;
                textMan.arrayPos = 20;
                Debug.Log("Try again!");
                // Give feedback
            }
        }
    }
}