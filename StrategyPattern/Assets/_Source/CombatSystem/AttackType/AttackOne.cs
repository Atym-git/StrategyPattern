using UnityEngine;

namespace CombatSystem.AttackType
{
    public class AttackOne : IAttackStrategy
    {
        private Animator _playerAnimator;
        private AnimationClip _attackClip;
        private float _damage;

        public AttackOne(Animator playerAnimator, AnimationClip attackClip, float damage)
        {
            _playerAnimator = playerAnimator;
            _attackClip = attackClip;
            _damage = damage;
        }

        public void Attack()
        {
            _playerAnimator.SetTrigger(_attackClip.name);
            Debug.Log($"Dealt {_damage} damage with Attack One");
        }
    }
}