using UnityEngine;
using UnityEngine.UI;

namespace Alpha.Phases.Rounding.Roundup
{
    public class MapButtonOpen : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private GameObject mapPanel;
        [SerializeField] private GameObject mapPanel2;
        [SerializeField] private Button mapButton;
        public bool map2Open;
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
            if (Input.GetKeyDown(KeyCode.M))
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
            if (!map2Open)
            {
                mapPanel.SetActive(!mapPanel.activeSelf);
            }
            else if (map2Open)
            {
                mapPanel2.SetActive(!mapPanel2.activeSelf);
            }
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