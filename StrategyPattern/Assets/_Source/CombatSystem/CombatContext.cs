using UnityEngine;

namespace CombatSystem
{
    public class CombatContext
    {
        private IAttackStrategy _currentAttack;

        public void SetStrategy(IAttackStrategy attackType)
        {
            _currentAttack = attackType;
        }

        public void PerformAttack()
        {
            if (_currentAttack != null)
            {
                _currentAttack.Attack();
            }
        }
    }
}