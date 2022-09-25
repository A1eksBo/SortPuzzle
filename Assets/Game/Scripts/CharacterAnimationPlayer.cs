using UnityEngine;

namespace SortPuzzle
{
    public class CharacterAnimationPlayer : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        private static readonly int SadIdle = Animator.StringToHash("PlaySadIdle");
        private static readonly int SillyDancing = Animator.StringToHash("PlaySillyDancing");    
        public void PlaySadIdle()
        {
            _animator.SetTrigger(SadIdle);
        }

        public void PlaySillyDancing()
        {
            _animator.SetTrigger(SillyDancing);
        }
    }
}
