using CombatSystem;
using CombatSystem.AttackType;
using CombatSystem.AttackType.Data;
using Core.InputSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Core.EntryPoint
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private AttackPerformer _attackPerformer;

        [SerializeField] private Animator _playerAnimator;

        [SerializeField] private Button _attackOneButton;
        [SerializeField] private Button _attackTwoButton;
        [SerializeField] private Button _attackThreeButton;

        private void Awake()
        {
            CombatContext combatContext = new CombatContext();

            ResourceLoader resourceLoader = new ResourceLoader();

            AttackTypeDataSO[] attackTypeDataSOs = resourceLoader.LoadAttackTypeData();

            if (attackTypeDataSOs.Length > 2)
            {
                AttackOne attackOne = new AttackOne(_playerAnimator,
                attackTypeDataSOs[0].AttackClip,
                attackTypeDataSOs[0].Damage);

                AttackTwo attackTwo = new AttackTwo(_playerAnimator,
                    attackTypeDataSOs[1].AttackClip,
                    attackTypeDataSOs[1].Damage);

                AttackThree attackThree = new AttackThree(_playerAnimator,
                    attackTypeDataSOs[2].AttackClip,
                    attackTypeDataSOs[2].Damage);

                _attackPerformer.Construct(combatContext, attackOne, attackTwo, attackThree);
            }
            
        }
    }
}


