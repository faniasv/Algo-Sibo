using UnityEngine;
using UnityEngine.UI;

namespace AlgoSibo.View
{
    public class MoveGroup : MonoBehaviour
    {
        [SerializeField] private Button moveButton;
        [SerializeField] private MoveSubButtonContainer moveSubButtonContainerComponent;

        private void Start()
        {
            moveButton.onClick.AddListener(HandleMoveButtonClicked);
        }

        private void HandleMoveButtonClicked()
        {
            if (moveSubButtonContainerComponent.IsActive())
            {
                moveSubButtonContainerComponent.Hide();
                return;
            }

            moveSubButtonContainerComponent.Show();
        }
    }
}
