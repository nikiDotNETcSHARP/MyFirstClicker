using System.Collections;
using Assets.Scripts;
using UnityEngine;

namespace Assembly_CSharp
{
    public class UpdateAge : MonoBehaviour
    {
        public static UpdateAge instance;

        [SerializeField] public float _gameSecond;
        [SerializeField] public static float _gameAge = 15;

        private MainButtons mainButtons = new MainButtons();

        private void Start()
        {
            StartCoroutine(UpdateAgeHero());

            _gameSecond = PlayerPrefs.GetFloat("_gameSecond", _gameSecond);
            _gameAge = PlayerPrefs.GetFloat("SavedAge", _gameAge);
        }

        void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject); // Не уничтожать объект при переходе между сценами

            }
            else
            {
                Destroy(gameObject);
            }
        }

        IEnumerator UpdateAgeHero()
        {
            while (true)
            {
                _gameSecond = _gameSecond + Time.deltaTime;

                if (_gameSecond >= 0.1f)
                {
                    _gameAge++;
                    _gameSecond = 0;

                    PlayerPrefs.SetFloat("SavedAge", _gameAge);
                    PlayerPrefs.SetFloat("_gameSecond", _gameSecond);
                }

                if (_gameAge >= 65)
                {
                    GameOver.OldAgeGameOver();
                    mainButtons.ResetGame();
                }

                yield return new WaitForSeconds(1.5f);
            }
        }

        public static void ResetAge()
        {
            _gameAge = 15;
            PlayerPrefs.SetFloat("SavedAge", _gameAge);
        }
    }
}
