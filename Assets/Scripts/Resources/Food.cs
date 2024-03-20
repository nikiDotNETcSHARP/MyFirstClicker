using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Burst.Intrinsics;
using UnityEngine;

namespace Assembly_CSharp
{
    public class Food : MonoBehaviour
    {
        public static Food instance;

        [SerializeField] protected float GameSecond;
        public static int _foodRate = 0;
        public static int _food = 0;

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

        private void Start()
        {
            StartCoroutine(UpdateWood());

            _food = PlayerPrefs.GetInt("_food", _food);
            _foodRate = PlayerPrefs.GetInt("_foodRate", _foodRate);
        }

        IEnumerator UpdateWood()
        {
            while (true)
            {
                GameSecond = GameSecond + Time.deltaTime;

                if (GameSecond >= 0.3f)
                {
                    _food += _foodRate;
                    GameSecond = 0;

                    PlayerPrefs.SetInt("_food", _food);
                }
                yield return new WaitForSeconds(1.5f); // Ожидание одной секунды перед следующим обновлением
            }
        }

        public static void NewFood(int newFood)
        {
            _foodRate += newFood;
            PlayerPrefs.SetInt("_foodRate", _foodRate);
        }

        public static void HireMan(int food)
        {
            _food -= food;
            PlayerPrefs.SetInt("_food", _food);
        }

        public static void ResetFood()
        {
            _food = 0;
            _foodRate = 0;

            PlayerPrefs.SetInt("_food", _food);
            PlayerPrefs.SetInt("_foodRate", _foodRate);
        }

    }
}
