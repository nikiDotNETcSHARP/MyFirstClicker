using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assembly_CSharp
{
    public class UpdateTime : MonoBehaviour
    {
        public static UpdateTime instance;

        [SerializeField] public float _gameSecond;
        [SerializeField] public static float _gameAge = 15;

        private void Start()
        {
            StartCoroutine(UpdateAge());

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

        IEnumerator UpdateAge()
        {
            while (true)
            {
                _gameSecond = _gameSecond + Time.deltaTime;

                if (_gameSecond >= 0.6f)
                {
                    _gameAge++;
                    _gameSecond = 0;

                    PlayerPrefs.SetFloat("SavedAge", _gameAge);
                    PlayerPrefs.SetFloat("_gameSecond", _gameSecond);
                }

                if (_gameAge >= 16)
                {
                    MainButtons.GameOver();
                    PlayerPrefs.SetFloat("SavedAge", _gameAge);
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
