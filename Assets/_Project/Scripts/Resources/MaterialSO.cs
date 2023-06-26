using UnityEngine;

namespace AlgoSibo.Resources
{
    [CreateAssetMenu(fileName = "NewMaterial", menuName = "AlgoSibo/Resources/Material")]
    public class MaterialSO : ItemSO
    {
        //==============================================================================
        // Functions
        //==============================================================================
        private void Awake()
        {
            type = ItemType.Material;
        }
    }
}
