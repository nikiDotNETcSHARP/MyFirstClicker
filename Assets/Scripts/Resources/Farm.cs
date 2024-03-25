using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Assembly_CSharp;

namespace Assets.Scripts
{
    public class Farm : MonoBehaviour
    {
        public static int _farm = 3;

        [SerializeField] public Text _farmText;

        private void Start()
        {
            StartCoroutine(UpdateText());

            _farm = PlayerPrefs.GetInt("_farm", _farm);
        }

        IEnumerator UpdateText()
        {
            while (true)
            {
                _farmText.text = _farm + " N";
                yield return new WaitForSeconds(0.3f); // Ожидание одной секунды перед следующим обновлением
            }
        }

        public static void ResetFarm()
        {
            _farm = 3;

            PlayerPrefs.SetInt("_farm", _farm);
        }

        public static void BuildFarm(int newFarm)
        {
            _farm += newFarm;
            PlayerPrefs.SetInt("_farm", _farm);
        }
    }
}
