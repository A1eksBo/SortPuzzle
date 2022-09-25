using UnityEngine;

namespace SortPuzzle
{
    public class VFXPoolProvider : MonoBehaviour
    {
        [SerializeField] private VFXPool _vfxPool;

        public VFXPool VFXPool => _vfxPool;

        private void Awake()
        {
            VFXPool.InitializePool();
        }
    }
}
