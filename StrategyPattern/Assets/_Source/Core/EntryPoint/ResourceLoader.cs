using CombatSystem.AttackType.Data;
using System.Linq;
using UnityEngine;

public class ResourceLoader
{
    public AttackTypeDataSO[] LoadAttackTypeData()
    {
        AttackTypeDataSO[] attackTypeDataSOs = Resources.LoadAll("SO/AttackTypeData", typeof (AttackTypeDataSO))
            .Cast<AttackTypeDataSO>()
            .ToArray();
        Debug.Log(attackTypeDataSOs.Length);
        return attackTypeDataSOs;
    }
}
