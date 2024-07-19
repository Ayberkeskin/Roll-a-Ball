using RunTime.Keys;
using RunTime.Signals;
using Unity.Mathematics;
using UnityEngine;

namespace RunTime.Managers
{
    public class InputManager :MonoBehaviour
    {
        #region Self Variables
        
        #region Private Variables
        
        private float2 _inputValues;
        
        #endregion
        
        #endregion

        private void Update()
        {
            _inputValues= GetInputValues(); 
            OnSendInput();
        }
       
        private void OnSendInput()
        {
            InputSignal.Instance.onInputTaken?.Invoke(new InputParams()
            {
                InputValues = _inputValues
            });
        }

        private float2 GetInputValues()
        {
             return new float2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }
    }
    }
