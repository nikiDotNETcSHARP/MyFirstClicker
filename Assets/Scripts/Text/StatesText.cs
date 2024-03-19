using Assets.Scripts.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Assembly_CSharp;
using Unity.Burst.Intrinsics;

namespace Assets.Scripts.States
{
    public class StatesText : MonoBehaviour
    {
        [SerializeField] public Text _vilitsoMinorText;
        public string _vilitsoMinor;

        public void Start()
        {
            StartCoroutine(UpdateStatesText());

            VilitsoMinor._name = PlayerPrefs.GetString("nameVilitso", VilitsoMinor._name);
            VilitsoMinor._money = PlayerPrefs.GetInt("_moneyVilitso", VilitsoMinor._money);
            VilitsoMinor._wood = PlayerPrefs.GetInt("_woodVilitso", VilitsoMinor._wood);
            VilitsoMinor._food = PlayerPrefs.GetInt("_foodVilitso", VilitsoMinor._food);
            VilitsoMinor._army = PlayerPrefs.GetInt("_armyVilitso", VilitsoMinor._army);

            _vilitsoMinor = VilitsoMinor.StateText(VilitsoMinor._name, VilitsoMinor._money, VilitsoMinor._wood,
                VilitsoMinor._food, VilitsoMinor._army);
        }

        IEnumerator UpdateStatesText()
        {
            while (true)
            {
                _vilitsoMinorText.text = _vilitsoMinor;
                yield return new WaitForSeconds(0.3f);
            }
        }
    }
}
