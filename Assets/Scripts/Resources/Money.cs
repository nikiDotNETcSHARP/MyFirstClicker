using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using JetBrains.Annotations;

namespace Assembly_CSharp
{
    public class Money : MonoBehaviour
    {
        public static int _money = 0;
        public static int _rate = 1;
        public static int _priceOfUpgradeRate = 15;
        public static int _uppModify = 1;

        [SerializeField] public Text _moneyText;
        [SerializeField] public Text _upgradeRateText;

        private void Start()
        {
            StartCoroutine(UpdateText());

            _money = PlayerPrefs.GetInt("money", 0);
            _rate = PlayerPrefs.GetInt("rate", 1);
            _priceOfUpgradeRate = PlayerPrefs.GetInt("priceOfUpgradeRate", 15);
            _uppModify = PlayerPrefs.GetInt("uppModify", 1);
        }

        IEnumerator UpdateText()
        {
            while (true)
            {
                _moneyText.text = "G: " + _money;
                _upgradeRateText.text = _priceOfUpgradeRate + "G";
                yield return new WaitForSeconds(0.3f);
            }
        }

        public void Click()
        {
            _money += _rate;
            PlayerPrefs.SetInt("money", _money);
        }

        public void UpgradeClick()
        {
            if (_money >= _priceOfUpgradeRate)
            {
                _money -= _priceOfUpgradeRate;
                _priceOfUpgradeRate += (_uppModify + _rate);

                _rate++;
                _uppModify++;
            }

            PlayerPrefs.SetInt("money", _money);
            PlayerPrefs.SetInt("rate", _rate);
            PlayerPrefs.SetInt("priceOfUpgradeRate", _priceOfUpgradeRate);
            PlayerPrefs.SetInt("uppModify", _uppModify);
        }

        public static void ResetMoney()
        {
            _money = 0;
            _rate = 1;
            _priceOfUpgradeRate = 15;
            _uppModify = 1;

            PlayerPrefs.SetInt("money", _money);
            PlayerPrefs.SetInt("rate", _rate);
            PlayerPrefs.SetInt("priceOfUpgradeRate", _priceOfUpgradeRate);
            PlayerPrefs.SetInt("uppModify", _uppModify);
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
