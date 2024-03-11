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
        [SerializeField] public float _gameAge = 15;

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
                yield return new WaitForSeconds(1.5f); // Ожидание одной секунды перед следующим обновлением
            }
        }

        public static void ResetAge(int startValue)
        {
            UpdateTime example = new UpdateTime();
            
            example._gameAge = startValue;
            PlayerPrefs.SetFloat("SavedAge", example._gameAge);
        }
    }
}
