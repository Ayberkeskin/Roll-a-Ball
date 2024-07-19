using System;

namespace RunTime.Data.VauleObjects
{
    [Serializable]
    public struct PlayerData
    {
        public PlayerMovmentData MovmentData;
    }
    
    [Serializable]
    public struct PlayerMovmentData
    {
        public float Speed;
    }
}