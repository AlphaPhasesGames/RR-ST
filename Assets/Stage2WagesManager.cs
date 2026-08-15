using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage2WagesManager : MonoBehaviour
    {
        [Header("Wages")]
        public int wagesValue;

        [Header("Display")]
        public TextMeshProUGUI onScreenValue;
        public TextMeshProUGUI onScreenValue2;
        public Stage2TextManager textMan;

        [Header("Player Answer UI")]
        [SerializeField] private TMP_InputField wagesInput;
        [SerializeField] private Button submitButton;

        private int playerAnswer;

        // Remembers whether we are currently rounding to 1000s.
        private bool roundingToThousands;

        private void Start()
        {
            wagesInput.contentType = TMP_InputField.ContentType.IntegerNumber;

            // Allows values such as 1000 and 10000.
            wagesInput.characterLimit = 5;

            wagesInput.onValueChanged.AddListener(OnInputChanged);
            wagesInput.onSubmit.AddListener(OnInputSubmitted);
            submitButton.onClick.AddListener(SubmitAnswer);

            UpdateWagesText();

            wagesInput.text = string.Empty;
        }

        private void Update()
        {
            UpdateWagesText();

            // First wages section: round to nearest 100.
            if (textMan.arrayPos == 9)
            {
                roundingToThousands = false;
            }

            // Second wages section: round to nearest 1000.
            if (textMan.arrayPos == 16)
            {
                roundingToThousands = true;
            }
        }

        private void OnDestroy()
        {
            if (wagesInput != null)
            {
                wagesInput.onValueChanged.RemoveListener(OnInputChanged);
                wagesInput.onSubmit.RemoveListener(OnInputSubmitted);
            }

            if (submitButton != null)
            {
                submitButton.onClick.RemoveListener(SubmitAnswer);
            }
        }

        private void UpdateWagesText()
        {
            if (onScreenValue != null)
            {
                onScreenValue.text = wagesValue.ToString();
            }

            if (onScreenValue2 != null)
            {
                onScreenValue2.text = wagesValue.ToString();
            }
        }

        private void OnInputChanged(string value)
        {
            if (int.TryParse(value, out int result))
            {
                playerAnswer = result;
            }
        }

        private void OnInputSubmitted(string value)
        {
            SubmitAnswer();
        }

        private void SubmitAnswer()
        {
            if (string.IsNullOrWhiteSpace(wagesInput.text) ||
                !int.TryParse(wagesInput.text, out playerAnswer))
            {
                ShowIncorrectFeedback();
                return;
            }

            int correctRoundedAnswer;

            if (roundingToThousands)
            {
                // Round to nearest 1000.
                // Adding 500 ensures values ending in 500 round UP.
                correctRoundedAnswer =
                    ((wagesValue + 500) / 1000) * 1000;
            }
            else
            {
                // Round to nearest 100.
                // Adding 50 ensures values ending in 50 round UP.
                correctRoundedAnswer =
                    ((wagesValue + 50) / 100) * 100;
            }

            Debug.Log(
                "Wages: " + wagesValue +
                " | Thousands Mode: " + roundingToThousands +
                " | Correct Answer: " + correctRoundedAnswer +
                " | Player Answer: " + playerAnswer
            );

            if (playerAnswer == correctRoundedAnswer)
            {
                textMan.ResetBools();
                textMan.positionChanged = true;

                if (roundingToThousands)
                {
                    // Correct thousands answer.
                    textMan.arrayPos = 17;
                }
                else
                {
                    // Correct hundreds answer.
                    textMan.arrayPos = 11;
                }

                wagesInput.text = string.Empty;

                Debug.Log("Correct wages rounding!");
            }
            else
            {
                ShowIncorrectFeedback();
            }
        }

        private void ShowIncorrectFeedback()
        {
            textMan.ResetBools();
            textMan.positionChanged = true;

            // At the moment both sections use array position 10
            // for incorrect feedback.
            textMan.arrayPos = 10;

            Debug.Log("Try again!");
        }
    }
}