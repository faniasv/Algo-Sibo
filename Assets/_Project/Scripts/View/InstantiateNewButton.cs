using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace AlgoSibo.View
{
    public class InstantiateNewButton : MonoBehaviour
    {
        [SerializeField] GameObject buttonPrefab;

        private void Update()
        {
            InstantiateButton();
        }

        private void InstantiateButton()
        {
            int buttonCount = transform.childCount;
            if (buttonCount == 0)
            {
                GameObject newButton = Instantiate(buttonPrefab);
                newButton.transform.SetParent(transform);

            }
        }
    }
}