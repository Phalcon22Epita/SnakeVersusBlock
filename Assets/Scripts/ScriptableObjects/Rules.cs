using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace svb
{
    [CreateAssetMenu(fileName = "New Rules", menuName = "New ScriptableObject/Rules")]
    public class Rules : ScriptableObject
    {
        [Header("Snake")]
        public float verticalSpeed = 8;
        public float horizontalSpeed = 8;
        [Space(5)]
        public int defaultFollowerAmount = 4;
        public float destructionDelay = 0.12f;
        public float destructionSlowDown = 0.5f;

        [Header("Camera")]
        public float cameraMaxDistance = 2;
        public float cameraSyncDist = 0.1f;

        [Header("Debug")]
        public bool godMode = false;
    }
}
