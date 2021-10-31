using UnityEngine;
using UnityEngine.Serialization;

namespace Commons
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Commons/StageConstrains", fileName = "StageConstrains")]
    public class StageConstrains : ScriptableObject
    {
        [SerializeField] private Vector3 border;
        [SerializeField] private Vector2 alienSpeed;

        public Vector3 Border => border;
        public Vector2 AlienSpeed
        {
            get => alienSpeed;
            set => alienSpeed = value;
        }
    }
}
