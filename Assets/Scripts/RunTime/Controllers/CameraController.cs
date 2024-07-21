using System;
using RunTime.Data.VauleObjects;
using RunTime.Keys;
using UnityEngine;

namespace RunTime.Controllers
{
    public class CameraController :MonoBehaviour
    {

        #region Self Variables
        
        #region Serialized Variables
        
        [SerializeField] private Transform targert;
        
        #endregion
        
        #region Private Variables
        
        private CameraDistanceData _distanceData;
        #endregion
        #endregion
        
        private void Start()
        {
            GetDistnace();
        }

        private void GetDistnace()
        {
            _distanceData.Distance = transform.position - targert.position;
        }

        private void LateUpdate()
        {
            FollowPlayer();
        }

        private void FollowPlayer()
        {
            transform.position = targert.position + _distanceData.Distance;
        }

        internal void SetDistanceData(CameraDistanceData distanceData)
        {
            _distanceData = distanceData;
        }
        
    }
}