using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace AlgoSibo.View
{
    public class MoveSubButtonSlot : MonoBehaviour, IDropHandler
    {
        public void OnDrop(PointerEventData eventData)
        {
            Debug.Log("Cok");
            GameObject dropped = eventData.pointerDrag;
            DraggableButton draggableButton = dropped.GetComponent<DraggableButton>();
            draggableButton.parentAfterDrag = transform;
        }
    }
}
