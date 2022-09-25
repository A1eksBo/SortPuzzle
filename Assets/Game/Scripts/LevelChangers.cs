using UnityEngine;
using UnityEngine.SceneManagement;

namespace SortPuzzle
{
    public class LevelChangers : MonoBehaviour
    {
        private GameObject _currentLevel;

        [SerializeField] private GameObject[] _levels;


        private void Start()
        {
            LoadLevel();
        }
        
        public void LoadLevel()
        {
            if (_currentLevel != null)
                Destroy(_currentLevel);
            
            var idx = SceneManager.GetActiveScene().buildIndex;
            var sceneCount = SceneManager.sceneCountInBuildSettings;
            var nextLevel = (idx) % sceneCount;
            
        }


        public void NextLevel()
        {
            var idx = SceneManager.GetActiveScene().buildIndex;
            var sceneCount = SceneManager.sceneCountInBuildSettings;
            var nextLevel = (idx+1) % sceneCount;
            PlayerPrefs.SetInt("Level", nextLevel);

            LoadLevel();
        }
    }
}
