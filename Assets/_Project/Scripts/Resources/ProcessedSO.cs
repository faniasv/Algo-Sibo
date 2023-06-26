using UnityEngine;

namespace AlgoSibo.Resources
{
    [CreateAssetMenu(fileName = "NewProcessed", menuName = "AlgoSibo/Resources/Processed")]
    public class ProcessedSO : ItemSO
    {
        //==============================================================================
        // Variables
        //==============================================================================
        [SerializeField] private int price;



        //==============================================================================
        // Functions
        //==============================================================================
        private void Awake()
        {
            type = ItemType.Processed;
        }
    }
}
