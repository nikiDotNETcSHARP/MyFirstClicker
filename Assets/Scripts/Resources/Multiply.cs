using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Assembly_CSharp;
using UnityEditor;


namespace Assembly_CSharp
{
    public class Multiply : MonoBehaviour
    {
        public static int _peoples = 1000;
        public static int _multiply = 10;

        [SerializeField] public Text _multiplyText;

        private void Start()
        {
            StartCoroutine(UpdateText());

            _peoples = PlayerPrefs.GetInt("_peoples", 1000);
            _multiply = PlayerPrefs.GetInt("_multiply", 10);
        }

        IEnumerator UpdateText()
        {
            while (true)
            {
                _multiplyText.text = "Жители: " + _peoples;
                yield return new WaitForSeconds(0.3f);
            }
        }

        public static void ResetMultiply()
        {
            _peoples = 1000;
            PlayerPrefs.SetInt("_peoples", _peoples);
        }

        public static void MultiplyCutWood(int people)
        {
            _peoples -= people;
            PlayerPrefs.SetInt("_peoples", _peoples);
        }

        public static void MultiplyBuildFarm(int people)
        {
            _peoples -= people;
            PlayerPrefs.SetInt("_peoples", _peoples);
        }

        public static void MultiplyArmy(int people)
        {
            _peoples -= people;
            PlayerPrefs.SetInt("_peoples", _peoples);
        }

        public static void Scouting(int scoutPeople)
        {
            _peoples -= scoutPeople;
            PlayerPrefs.SetInt("_peoples", _peoples);
        }
    }
}
