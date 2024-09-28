using UnityEngine;

public class Tower : MonoBehaviour, IAttacker, IEnemy
{
    private RangeAttack _attackBehaviour;

    public void Initialize(RangeAttack attackBehaviour) => _attackBehaviour = attackBehaviour;

    public void Attack() => _attackBehaviour.Attack();
}
