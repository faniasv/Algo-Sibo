using UnityEngine;
using TMPro;

namespace AlgoSibo.Core
{
    public class GridDebug : MonoBehaviour
    {
        [SerializeField] private MeshRenderer meshRenderer;
        [SerializeField] private TextMeshPro gridText;
        private GridObject gridObject;

        private void Update()
        {
            gridText.text = gridObject.ToString();
        }

        public void SetGridObject(GridObject _gridObject)
        {
            this.gridObject = _gridObject;
        }

        public void Show()
        {
            meshRenderer.enabled = true;
            gridText.enabled = true;
        }

        public void Hide()
        {
            meshRenderer.enabled = false;
            gridText.enabled = false;
        }
    }
}