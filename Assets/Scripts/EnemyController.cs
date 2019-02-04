using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using turn;

public class EnemyController : MonoBehaviour
{
    private TurnChecker turnChecker;
    private PlayerController _playerController;

    private int totalDamage;
    [SerializeField]
    private int health = 100;

    private void Awake()
    {
        turnChecker = FindObjectOfType<TurnChecker>();
        _playerController = FindObjectOfType<PlayerController>();
    }

    public void TakeDamage(int dmg)
    {
        //play dmg animation
        health -= dmg;

        if (health <= 0)
        {
            //play death animation
            //game over panel
        }
    }

    public void StartAnimation()
    {
        //start animation here
    }

    public void DealDamage()
    {
        totalDamage = 40;
        _playerController.TakeDamage(totalDamage);
        turnChecker.WaitForMethod(3);
    }
}
