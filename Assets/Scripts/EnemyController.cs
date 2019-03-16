using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using turn;

public class EnemyController : MonoBehaviour
{
    private TurnChecker turnChecker;
    private PlayerController _playerController;

    private Animator anim;

    private int totalDamage;
    [SerializeField]
    private int health = 100;

    private void Awake()
    {
        turnChecker = FindObjectOfType<TurnChecker>();
        _playerController = FindObjectOfType<PlayerController>();
        anim = GetComponent<Animator>();
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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetInteger("EnemyHealth", 0);
        }
    }

    public void DealDamage()
    {
        totalDamage = 40;
        _playerController.TakeDamage(totalDamage);
        turnChecker.WaitForMethod(3);
    }
}
