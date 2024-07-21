using System;
using RunTime.Enums;
using UnityEngine;

namespace RunTime.Controllers
{
    public class PlayerPhysicsController : MonoBehaviour
    { 
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag(EnumTags.Coin.ToString()))
            {
                Destroy(other.gameObject);
            }
        }
    }
}
