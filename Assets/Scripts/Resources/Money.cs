using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Assembly_CSharp
{
    public class Money : MonoBehaviour
    {
        public static int _money = 0;
        public static int _rate = 1;

        [SerializeField] public Text _moneyText;

        private void Start()
        {
            StartCoroutine(UpdateText());

            _money = PlayerPrefs.GetInt("money", 0);
            _rate = PlayerPrefs.GetInt("rate", 1);
        }

        IEnumerator UpdateText()
        {
            while (true)
            {
                _moneyText.text = "G: " + _money;
                yield return new WaitForSeconds(0.3f); // Ожидание одной секунды перед следующим обновлением
            }
        }

        public void Click()
        {
            _money += _rate;
            PlayerPrefs.SetInt("money", _money);
        }

        public void UpgradeClick()
        {
            if (_money >= 15)
            {
                _money -= 15;
                _rate += 1;
            }

            PlayerPrefs.SetInt("money", _money);
            PlayerPrefs.SetInt("rate", _rate);
        }

        public static void ResetMoney(int zero)
        {
            _money *= zero;
            _rate = 1;

            PlayerPrefs.SetInt("money", _money);
            PlayerPrefs.SetInt("rate", _rate);
        }

        public static void MoneyCutWood(int money)
        {
            _money -= money;
            PlayerPrefs.SetInt("money", _money);
        }

        public static void MoneyBuildFarm(int money)
        {
            _money -= money;
            PlayerPrefs.SetInt("money", _money);
        }

    }
}
