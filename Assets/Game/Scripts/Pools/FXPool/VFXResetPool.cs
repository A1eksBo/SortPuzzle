using UnityEngine;

namespace SortPuzzle
{
    public class VFXResetPool : MonoBehaviour
    {
        [SerializeField] private VFXPool _vfxPool;

        private void OnDisable()
        {
            _vfxPool.ResetPool();
        }
    }
}
