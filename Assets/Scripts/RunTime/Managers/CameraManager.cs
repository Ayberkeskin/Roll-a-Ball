using System;
using RunTime.Controllers;
using RunTime.Data.UnityObjects;
using RunTime.Data.VauleObjects;
using UnityEngine;

namespace RunTime.Managers
{
    public class CameraManager :MonoBehaviour
    {
        #region Self Variables

        #region Serialized Variables

        [SerializeField] private CameraController _cameraController;

        #endregion

        #region Private Variables

        private CameraData _data;

        #endregion

        #endregion

        private void Awake()
        {
            GetCameraData();

            SendDataControllers();
        }

        private void GetCameraData()
        {
            _data= Resources.Load<CD_Camera>("Data/CD_Camera").Data;
        }
        
        private void SendDataControllers()
        {
            _cameraController.SetDistanceData(_data.DistanceData);
        }
    }
}