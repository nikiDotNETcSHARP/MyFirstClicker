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
        public static int _farm = 0;
        public static int _newFarm = 1;

        [SerializeField] public Text _farmText;

        private void Start()
        {
            StartCoroutine(UpdateText());

            _farm = PlayerPrefs.GetInt("_farm", _farm);
            _newFarm = PlayerPrefs.GetInt("_newFarm", 1);
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
            _farm = 0;
            _newFarm = 1;

            PlayerPrefs.SetInt("_farm", _farm);
            PlayerPrefs.SetInt("_newFarm", _newFarm);
        }

        public static void BuildFarm(int newFarm)
        {
            _farm += newFarm;
            PlayerPrefs.SetInt("_farm", _farm);
        }
    }
}
