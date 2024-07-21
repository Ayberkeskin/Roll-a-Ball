using System;
using RunTime.Controllers;
using RunTime.Data.UnityObjects;
using RunTime.Data.VauleObjects;
using RunTime.Signals;
using UnityEngine;

namespace RunTime.Managers
{
    public class PlayerManager :MonoBehaviour
    {
        #region Self Variables

        #region Serialized Variables

        [SerializeField] private PlayerMovmentController _movmentController;
        [SerializeField] private PlayerPhysicsController _physicsController;

        #endregion

        #region Private Variables

        private PlayerData _data;

        #endregion

        #endregion

        private void Awake()
        {
            GetPlayerData();
            SendDataControllers();
        }
        

        private void GetPlayerData()
        {
           _data= Resources.Load<CD_Player>("Data/CD_Player").Data;
        }

        private void OnEnable()
        {
            SubscribeEvents();
        }

        private void OnDisable()
        {
            UnSubscribeEvents();
        }

        private void SubscribeEvents()
        {
            InputSignal.Instance.onInputTaken += _movmentController.OnInputTaken;
        }

        private void UnSubscribeEvents()
        {
            InputSignal.Instance.onInputTaken -= _movmentController.OnInputTaken;
        }
        
        private void SendDataControllers()
        {
            _movmentController.SetMovmentData(_data.MovmentData);
            _physicsController.SetScoreData(_data.ScoreData);
        }
    }
    
}