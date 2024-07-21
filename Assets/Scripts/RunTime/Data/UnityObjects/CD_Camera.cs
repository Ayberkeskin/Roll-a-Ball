using RunTime.Data.VauleObjects;
using UnityEngine;

namespace RunTime.Data.UnityObjects
{
    [CreateAssetMenu(fileName = "CD_Camera", menuName = "TestGame/CD_Camera", order = 0)]
    public class CD_Camera : ScriptableObject
    {
        public CameraData Data;
    }
}