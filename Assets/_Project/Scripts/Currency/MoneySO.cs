using UnityEngine;

namespace AlgoSibo.Currency
{
    [CreateAssetMenu(fileName = "Money", menuName = "AlgoSibo/Currency/Money", order = 0)]
    public class MoneySO : ScriptableObject
    {
        [SerializeField] private int money;
        public int Money { get { return money; } set { this.money = value; } }

        public void Increase(int value)
        {
            this.money += value;
        }

        public void Decrease(int value)
        {
            this.money -= value;
        }
    }
}