using UnityEngine;
using UnityEngine.Events;

namespace Core
{
    [RequireComponent(typeof(Player))]
    public class PlayerForce : MonoBehaviour
    {
        private int _startForce;
        private int _currentForce;
        
        public UnityEvent<int> _forceChanged;

        public int CurrentForce => _currentForce;

        public void AddForce(int value)
        {
            
        }
        
        public bool TrySpendForce(int value)
        {
            if (_currentForce < value)
                return false;
            
            SpendForce(value);
            return true;
        }

        private void SpendForce(int value)
        {
            _currentForce -= value;
        }
    }
}