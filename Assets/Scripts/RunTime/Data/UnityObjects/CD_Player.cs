using RunTime.Data.VauleObjects;
using UnityEngine;

namespace RunTime.Data.UnityObjects
{
    [CreateAssetMenu(fileName = "CD_Player", menuName = "TestGame/CD_Player", order = 0)]
    public class CD_Player : ScriptableObject
    {
        public PlayerData Data;
    }
}