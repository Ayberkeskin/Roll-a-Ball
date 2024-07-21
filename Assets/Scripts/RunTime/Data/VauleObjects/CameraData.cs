using System;
using UnityEngine;

namespace RunTime.Data.VauleObjects
{
    [Serializable]
    public struct CameraData
    {
        public CameraDistanceData DistanceData;
    }
    
    [Serializable]
    public struct CameraDistanceData
    {
        public Vector3 Distance;
    }
}