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

        private void Start()
        {
            wagesInput.contentType = TMP_InputField.ContentType.IntegerNumber;

            wagesInput.characterLimit = 3;

            wagesInput.onValueChanged.AddListener(OnInputChanged);
            wagesInput.onSubmit.AddListener(OnInputSubmitted);
            submitButton.onClick.AddListener(SubmitAnswer);

            UpdateWagesText();

            wagesInput.text = string.Empty;
        }

        private void Update()
        {
            onScreenValue.text = wagesValue.ToString();
            onScreenValue2.text = wagesValue.ToString();
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

            int correctRoundedAnswer =
                Mathf.RoundToInt(wagesValue / 100f) * 100;

            if (playerAnswer == correctRoundedAnswer)
            {
                textMan.ResetBools();
                textMan.positionChanged = true;
                textMan.arrayPos = 11;

                Debug.Log("Correct wages rounding!");
            }
            else
            {
                ShowIncorrectFeedback();
            }
        }

        private void ShowIncorrectFeedback()
        {
            textMan.positionChanged = true;
            textMan.arrayPos = 10;

            Debug.Log("Try again!");
        }
    }
}