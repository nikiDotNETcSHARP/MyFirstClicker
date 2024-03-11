using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Burst.Intrinsics;
using UnityEngine;
using UnityEngine.UI;

namespace Assembly_CSharp
{
    public class Manpower : MonoBehaviour
    {
        public static int _manpower = 0;

        [SerializeField] public Text _manText;

        private void Start()
        {
            StartCoroutine(UpdateManText());

            _manpower = PlayerPrefs.GetInt("_manpower", _manpower);
        }

        IEnumerator UpdateManText()
        {
            while (true)
            {
                _manText.text = "Армия: " + _manpower;
                yield return new WaitForSeconds(0.3f); // Ожидание одной секунды перед следующим обновлением
            }
        }

        public static void HireManpower(int man)
        {
            _manpower += man;
            PlayerPrefs.SetInt("_manpower", _manpower);
        }

        public static void ResetMan(int zero)
        {
            _manpower *= zero;
            PlayerPrefs.SetInt("_manpower", _manpower);
        }
    }
}
