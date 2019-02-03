using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using turn;

public class PlayerController : ICharacterController
{
    private readonly TurnChecker turnChecker = new TurnChecker();

    public void AnimationEventTest()
    {
        turnChecker.checkTurn = TurnChecker.Turn.Player;
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
