using Assets.Scripts.States;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Princess : MonoBehaviour
    {
        public Sprite _tombekiyaPrincess;
        public Sprite _serborotPrincess;
        public Sprite _toliviyaPrincess;
        public Sprite _vilitsoPrincess;

        public Sprite _zeroPrincess;

        public Image _princess1;
        public Image _princess2;
        public Image _princess3;
        public Image _princess4;

        private void Start()
        {
            StartCoroutine(UpdatePrincess());

            VilitsoMinor._army = PlayerPrefs.GetInt("_armyVilitso", VilitsoMinor._army);
            Tombekiya._army = PlayerPrefs.GetInt("_armyTombekiya", Tombekiya._army);
            Serborot._army = PlayerPrefs.GetInt("_armySerborot", Serborot._army);
            Toliviya._army = PlayerPrefs.GetInt("_armyToliviya", Toliviya._army);
        }

        IEnumerator UpdatePrincess()
        {
            while (true)
            {
                if (Tombekiya._army <= 0)
                {
                    _princess1.sprite = _tombekiyaPrincess;
                }
                else
                {
                    _princess1.sprite = _zeroPrincess;
                }


                if (Serborot._army <= 0)
                {
                    _princess2.sprite = _serborotPrincess;
                }
                else
                {
                    _princess2.sprite = _zeroPrincess;
                }


                if (Toliviya._army <= 0)
                {
                    _princess3.sprite = _toliviyaPrincess;
                }
                else
                {
                    _princess3.sprite = _zeroPrincess;
                }


                if (VilitsoMinor._army <= 0)
                {
                    _princess4.sprite = _vilitsoPrincess;
                }
                else
                {
                    _princess4.sprite = _zeroPrincess;
                }

                yield return new WaitForSeconds(1.5f);
            }
        }
    }
}
