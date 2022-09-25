using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace SortPuzzle
{
    public class ItemClickFx : MonoBehaviour, IPointerDownHandler
    
    {
        [SerializeField] private GameObject _circleClickFxPrefab;

        public UnityEvent OnClick;

        public void OnPointerDown(PointerEventData eventData)
        {
            Instantiate(_circleClickFxPrefab, transform.position, Quaternion.identity, null);

            OnClick.Invoke();
        }
    }
}
