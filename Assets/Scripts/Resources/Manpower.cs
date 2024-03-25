using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assembly_CSharp
{
    public class Manpower : MonoBehaviour
    {
        public static int _manpower = 3000;

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
                yield return new WaitForSeconds(0.3f);
            }
        }

        public static void HireManpower(int man)
        {
            _manpower += man;
            PlayerPrefs.SetInt("_manpower", _manpower);
        }

        public static void Raid()
        {
            if (_manpower < 0)
            {
                _manpower = 0;

                PlayerPrefs.SetInt("_manpower", _manpower);
            }
        }

        public static void Scouting(int scoutArmy)
        {
            _manpower -= scoutArmy;
            PlayerPrefs.SetInt("_manpower", _manpower);
        }

        public static void ResetMan()
        {
            _manpower = 3000;
            PlayerPrefs.SetInt("_manpower", _manpower);
        }
    }
}
