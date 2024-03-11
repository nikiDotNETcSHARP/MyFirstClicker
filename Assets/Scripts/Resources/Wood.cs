using Assembly_CSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


namespace Assembly_CSharp
{
    public class Wood : MonoBehaviour
    {
        public static Wood instance;

        [SerializeField] protected float GameSecond;
        public static int _cutWood = 1;
        public static int _wood = 0;

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

            _wood = PlayerPrefs.GetInt("wood", _wood);
            _cutWood = PlayerPrefs.GetInt("_cutWood", _cutWood);
        }

        IEnumerator UpdateWood()
        {
            while (true)
            {
                GameSecond = GameSecond + Time.deltaTime;

                if (GameSecond >= 0.3f)
                {
                    _wood += _cutWood;
                    GameSecond = 0;

                    PlayerPrefs.SetInt("wood", _wood);
                }
                yield return new WaitForSeconds(1.5f); // Ожидание одной секунды перед следующим обновлением
            }
        }

        public static void CutWood(int CutWood)
        {
            _cutWood += CutWood;
            PlayerPrefs.SetInt("_cutWood", _cutWood);
        }

        public static void ResetWood(int zero, int one)
        {
            _cutWood = one;
            _wood = zero;

            PlayerPrefs.SetInt("wood", _wood);
            PlayerPrefs.SetInt("_cutWood", _cutWood);
        }

        public static void WoodBuildFarm(int wood)
        {
            _wood -= wood;
            PlayerPrefs.SetInt("wood", _wood);
        }
    }
}
