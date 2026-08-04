using UnityEngine;
using UnityEngine.UI;

namespace Alpha.Phases.Rounding.Roundup
{
    public class JournalOpenButton : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private GameObject mapPanel;
        [SerializeField] private Button mapButton;

        private void Awake()
        {
            if (mapButton != null)
            {
                mapButton.onClick.AddListener(ToggleMap);
            }
        }

        private void Start()
        {
            if (mapPanel != null)
            {
                mapPanel.SetActive(false);
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                ToggleMap();
            }
        }

        private void OnDestroy()
        {
            if (mapButton != null)
            {
                mapButton.onClick.RemoveListener(ToggleMap);
            }
        }

        public void ToggleMap()
        {
            if (mapPanel == null)
                return;

            mapPanel.SetActive(!mapPanel.activeSelf);
        }

        public void OpenMap()
        {
            if (mapPanel == null)
                return;

            mapPanel.SetActive(true);
        }

        public void CloseMap()
        {
            if (mapPanel == null)
                return;

            mapPanel.SetActive(false);
        }
    }
}