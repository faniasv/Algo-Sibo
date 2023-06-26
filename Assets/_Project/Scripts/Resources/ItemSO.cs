using UnityEngine;
using System.Text.RegularExpressions;

namespace AlgoSibo.Resources
{
    /// <summary>
    /// It just item, what you expect ?
    /// </summary>
    public abstract class ItemSO : ScriptableObject
    {
        //==============================================================================
        // Variables
        //==============================================================================
        [SerializeField] protected GameObject prefab;
        [SerializeField] protected ItemType type;



        //==============================================================================
        // Functions
        //==============================================================================
        /// <summary>
        /// Get item name with space between words.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string[] split = Regex.Split(name, @"(?<!^)(?=[A-Z])");

            return string.Join(" ", split);
        }
    }
}
