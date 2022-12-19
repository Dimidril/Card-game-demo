using System;
using UnityEngine;
using UnityEngine.Events;

namespace Core
{
    [RequireComponent(typeof(Player))]
    public class PlayerHealth : MonoBehaviour
    {
        private int _startHealth;
        private int _currentHealth;

        public UnityEvent<int> _healthChanged;
        public UnityEvent _died;

        public int CurrentHealth => _currentHealth;
        
        private void Awake()
        {
            _currentHealth = _startHealth;
        }

        public void AddHealth(int value)
        {
            _currentHealth += value;
            _healthChanged.Invoke(_currentHealth);
        }

        public void TakeDamage(int value)
        {
            _currentHealth -= value;

            if (_currentHealth <= 0)
                _died.Invoke();
            
            _healthChanged.Invoke(_currentHealth);
        }
    }
}