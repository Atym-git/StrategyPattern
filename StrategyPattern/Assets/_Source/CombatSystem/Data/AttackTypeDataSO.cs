using UnityEngine;
using UnityEngine.UI;

namespace CombatSystem.AttackType.Data
{
    [CreateAssetMenu(fileName = "New Attack Type", menuName = "SO/New Attack Type")]
    public class AttackTypeDataSO : ScriptableObject
    {
        //[field: SerializeField]
        //public Animator PlayerAnimator { get; private set; }

        [field: SerializeField]
        public AnimationClip AttackClip { get; private set; }

        [field: SerializeField]
        public float Damage { get; private set; }

        //[field: SerializeField]
        //public Button AffectedButton { get; private set; }
    }
}
