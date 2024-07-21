using System;
using RunTime.Controllers;
using RunTime.Data.UnityObjects;
using RunTime.Data.VauleObjects;
using TMPro;
using UnityEngine;

namespace RunTime.Managers
{
    public class UIManager:MonoBehaviour
    {
        #region Self Variabeles

        #region Serialized Variables
        
        [SerializeField] private TextMeshProUGUI _scoreText;
        [SerializeField] private PlayerPhysicsController _physicsController;
        
        #endregion
        
        #region Private Variables
        
        private PlayerData _data;
        
        #endregion
        
        #endregion

        private void Awake()
        {
            GetPlayerData();
        }

        private void Update()
        {
            _scoreText.text = _physicsController.SendScore().ToString();
        }

        private void GetPlayerData()
        {
            _data= Resources.Load<CD_Player>("Data/CD_Player").Data;
        }
    }
}