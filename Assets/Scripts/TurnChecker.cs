using UnityEngine;

namespace turn
{
    public class TurnChecker : MonoBehaviour
    {
        /// <summary>
        /// checks who's turn it is 
        /// </summary>

        public Turn checkTurn;

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
                    Debug.Log("player turn");
                    break;
                case Turn.Enemy:
                    Debug.Log("enemy turn");
                    break;
                default:
                    Debug.Log("default");
                    break;
            }
        }
    }
}