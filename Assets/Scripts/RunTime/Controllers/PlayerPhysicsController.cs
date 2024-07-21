using System;
using RunTime.Data.VauleObjects;
using RunTime.Enums;
using UnityEngine;

namespace RunTime.Controllers
{
    public class PlayerPhysicsController : MonoBehaviour
    {
        #region Self Varibales

        #region Private Variables

        private PlayerScoreData _data;
        
        private int _score = 50;

        #endregion
        
        #endregion
    
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag(EnumTags.Coin.ToString()))
            {
                _data.Score += _score;
                Destroy(other.gameObject);
                Debug.LogWarning(_data.Score);
            }
        }
        
        internal void SetScoreData(PlayerScoreData scoreData)
        {
            _data = scoreData;
        }

        internal int SendScore()
        {
            return _data.Score;
        }
    }
}
