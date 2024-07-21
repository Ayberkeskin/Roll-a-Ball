using System;
using RunTime.Data.VauleObjects;
using RunTime.Keys;
using RunTime.Managers;
using Unity.Mathematics;
using UnityEngine;

namespace RunTime.Controllers
{
    public class PlayerMovmentController :MonoBehaviour
    {
        #region Self Variables

        #region Serialized Variables

        [SerializeField] private PlayerManager _manager;
        
        #endregion

        #region Rrivate Variables

        private Rigidbody _rigidbody;
        private PlayerMovmentData _data;
        private float2 _inputValues;

        #endregion
        

        #endregion

        private void Awake()
        {
            GetReferences();
        }

        private void FixedUpdate()
        {
            MovePlayer();
        }
        
        private void GetReferences()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }
        
        internal void SetMovmentData(PlayerMovmentData movmentData)
        {
            _data = movmentData;
        }

        internal void OnInputTaken(InputParams inputParams)
        {
            _inputValues = inputParams.InputValues;
           
        }
        
        private void MovePlayer()
        {
            _rigidbody.velocity += new Vector3(_inputValues.x,0, _inputValues.y) * (_data.Speed * Time.fixedDeltaTime);
      
        }
    }
}