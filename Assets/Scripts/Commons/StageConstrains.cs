using UnityEngine;

namespace Commons
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Commons/StageConstrains", fileName = "StageConstrains")]
    public class StageConstrains : ScriptableObject
    {
        [SerializeField] private Vector3 border;

        public Vector3 Border => border;
    }
}
