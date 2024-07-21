using System;
using UnityEngine;

namespace RunTime.Managers
{
    public class GameManager :MonoBehaviour
    {
        #region Self Variables

        #region Serialized Variables

        [SerializeField] private GameObject[] _coins;
        
        [SerializeField] private UIManager _uıManager;
        
        #endregion

        #endregion

        private void Update()
        {
            CheckGameOver();
        }

        private void CheckGameOver()
        {
            bool allCoinsCollected = true;

            for (int i = 0; i < _coins.Length; i++)
            {
                if (_coins[i] != null)
                {
                    allCoinsCollected = false;
                    break;
                }
            }

            if (allCoinsCollected)
            {
                _uıManager.GameOver();
            }
        }
        
    }
}