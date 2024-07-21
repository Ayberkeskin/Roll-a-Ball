using RunTime.Controllers;
using TMPro;
using UnityEngine;

namespace RunTime.Managers
{
    public class UIManager:MonoBehaviour
    {
        #region Self Variabeles
        #region Serialized Variables
        
        [SerializeField] private TextMeshProUGUI _scoreText;
        [SerializeField] private TextMeshProUGUI _gameOverText;
        [SerializeField] private PlayerPhysicsController _physicsController;
        
        #endregion
        #endregion
        
        private void Update()
        {
            _scoreText.text = _physicsController.SendScore().ToString();
        }

        internal void GameOver()
        {
            _gameOverText.gameObject.SetActive(true);
            Debug.LogWarning("Game Over");
        }
    }
}