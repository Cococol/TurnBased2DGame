using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

namespace turn
{
    public class TurnChecker : MonoBehaviour
    {
        /// <summary>
        /// checks who's turn it is 
        /// </summary>

        private PlayerController _playerController;
        private EnemyController _enemyController;

        public Turn checkTurn;

        private void Awake()
        {
            _playerController = FindObjectOfType<PlayerController>();
            _enemyController = FindObjectOfType<EnemyController>();
        }

        public enum Turn
        {
            Player,

            Enemy,
        }

        public void CheckEnumState()
        {
            switch (checkTurn)
            {
                case Turn.Player:
                    _playerController.StartAnimation();
                    Debug.Log("player turn");
                    break;
                case Turn.Enemy:
                    _enemyController.StartAnimation();
                    Debug.Log("enemy turn");
                    break;
                default:
                    Debug.Log("default");
                    break;
            }
        }

        public IEnumerator WaitForMethod(float t)
        {
            yield return new WaitForSeconds(t);
            CheckEnumState();
        }
    }
}
