using System;

namespace RunTime.Data.VauleObjects
{
    [Serializable]
    public struct PlayerData
    {
        public PlayerMovmentData MovmentData;
        public PlayerScoreData ScoreData;
    }
    
    [Serializable]
    public struct PlayerMovmentData
    {
        public float Speed;
      
    }
    
    [Serializable]
    public struct PlayerScoreData
    {
        public int Score;
    }
}