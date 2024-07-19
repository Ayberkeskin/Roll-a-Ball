using System;
using RunTime.Keys;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;

namespace RunTime.Signals
{
    public class InputSignal:MonoBehaviour
    {
        #region Singleton

        public static InputSignal Instance;

        private void Awake()
        {
            if (Instance!=null&&Instance!=this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
        }

        #endregion

        public UnityAction<InputParams> onInputTaken = delegate { };
    }
}