using UnityEngine;

namespace AlgoSibo.Resources
{
    [CreateAssetMenu(fileName = "NewProduct", menuName = "AlgoSibo/Resources/Product")]
    public class ProductSO : ItemSO
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
            type = ItemType.Product;
        }
    }
}
