using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace AlgoSibo.View
{
    public class MoveSubButtonContainer : MonoBehaviour
    {
        [Header("Move Input")]
        [SerializeField] private Button upButton;
        [SerializeField] private Button leftButton;
        [SerializeField] private Button rightButton;
        [SerializeField] private Button downButton;

        [SerializeField] private TextMeshProUGUI buttonPreview;

        private void Start()
        {
            upButton.onClick.AddListener(() =>
            {
                Debug.Log("Forward button clicked");
                buttonPreview.text = "Forward";

            });
            leftButton.onClick.AddListener(() =>
            {
                Debug.Log("Backward button clicked");
                buttonPreview.text = "Backward";
            });
            rightButton.onClick.AddListener(() =>
            {
                Debug.Log("Right button clicked");
                buttonPreview.text = "Right";
            });
            downButton.onClick.AddListener(() =>
            {
                Debug.Log("Down button clicked");
                buttonPreview.text = "Down";
            });
        }

        public void Show()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }

        public bool IsActive()
        {
            return gameObject.activeSelf;
        }
    }
}
