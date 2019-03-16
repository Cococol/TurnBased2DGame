using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using turn;

public class PlayerController : MonoBehaviour
{
    private TurnChecker turnChecker;
    private EnemyController _enemyController;

    private Animator anim;


    private int totalDamage;
    [SerializeField]
    private int health = 100;

    private void Awake()
    {
        turnChecker = FindObjectOfType<TurnChecker>();
        _enemyController = FindObjectOfType<EnemyController>();
        anim = GetComponent<Animator>();
    }


    public void StartAnimation()
    {
        //start animation here
    }

    public void TakeDamage(int dmg)
    {
        //play dmg animation
        health -= dmg;

        if (health <= 0)
        {
            anim.SetInteger("PlayerHealth", 0);
            //game over panel
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetInteger("PlayerHealth", 0);
        }
    }

    public void DealDamage()
    {
        totalDamage = 40;
        _enemyController.TakeDamage(totalDamage);
        turnChecker.WaitForMethod(3);
    }
}
