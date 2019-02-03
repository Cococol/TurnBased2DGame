using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using turn;

public class EnemyController : MonoBehaviour, ICharacterController
{
    private readonly TurnChecker turnChecker = new TurnChecker();

    public void AnimationEventTest()
    {
        turnChecker.checkTurn = TurnChecker.Turn.Enemy;
        turnChecker.CheckEnumState();
    }

    public void TakeDamage(int damage)
    {

    }

    public void DealDamage(int damage, TurnChecker.Turn turn)
    {
        throw new System.NotImplementedException();
    }
}
