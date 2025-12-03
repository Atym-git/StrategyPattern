using CombatSystem;
using CombatSystem.AttackType;
using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Core.InputSystem
{

    public class AttackPerformer : MonoBehaviour
    {
        private InputAction _attackAction;

        private CombatContext _combatContext;

        private InputSystem_Actions _inputActions;

        private AttackOne _attackOne;
        private AttackTwo _attackTwo;
        private AttackThree _attackThree;

        public void Construct(CombatContext combatContext,
            AttackOne attackOne,
            AttackTwo attackTwo,
            AttackThree attackThree)
        {
            _combatContext = combatContext;

            _attackOne = attackOne;
            _attackTwo = attackTwo;
            _attackThree = attackThree;
        }

        private void Start()
        {
            _inputActions = new InputSystem_Actions();

            Bind(_inputActions);
        }

        private void OnDisable() => UnBind();

        private void Bind(InputSystem_Actions inputActions)
        {
            _attackAction = inputActions.Player.Attack;
            _attackAction.Enable();
            _attackAction.performed += AttackPerformed;
        }      

        public void AttackOne()
        {
            _combatContext.SetStrategy(_attackOne);
        }
        
        public void AttackTwo()
        {
            _combatContext.SetStrategy(_attackTwo);
        }
        
        public void AttackThree()
        {
            _combatContext.SetStrategy(_attackThree);
        }

        private void AttackPerformed(InputAction.CallbackContext obj)
        {
            _combatContext.PerformAttack();
        }

        private void UnBind()
        {
            _attackAction.Disable();
            _inputActions.Player.Disable();
        }
    }
}
