using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace AlgoSibo.View
{
    public class DraggableButton : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        public Image item;

        [HideInInspector] public Transform parentAfterDrag;
        [HideInInspector] public Transform parentBeforeDrag;
        public void OnBeginDrag(PointerEventData eventData)
        {
            Debug.Log("Anjay");
            parentBeforeDrag = transform.parent;
            parentAfterDrag = transform.parent;
            transform.SetParent(transform.root);
            transform.SetAsLastSibling();
            item.raycastTarget = false;

        }

        void IDragHandler.OnDrag(PointerEventData eventData)
        {
            Debug.Log("Anjay Dua");
            transform.position = Input.mousePosition;
        }

        void IEndDragHandler.OnEndDrag(PointerEventData eventData)
        {
            Debug.Log("Dropped");
            transform.SetParent(parentAfterDrag);
            item.raycastTarget = true;
            if (parentAfterDrag.tag == "Left Panel" && parentBeforeDrag.tag == "Right Panel")
            {
                Destroy(gameObject);
            }
        }
    }
}