using Assets.Scripts.States;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Achievements : MonoBehaviour
    {
        public Sprite Ach1;
        public Sprite Ach2;
        public Sprite Zero;

        public Image imageComponent1;
        public Image imageComponent2;

        [SerializeField] public Text _victory;
        [SerializeField] public Text _harem;

        private void Start()
        {
            StartCoroutine(UpdateAch());

            VilitsoMinor._army = PlayerPrefs.GetInt("_armyVilitso", VilitsoMinor._army);
            Tombekiya._army = PlayerPrefs.GetInt("_armyTombekiya", Tombekiya._army);
            Serborot._army = PlayerPrefs.GetInt("_armySerborot", Serborot._army);
            Toliviya._army = PlayerPrefs.GetInt("_armyToliviya", Toliviya._army);
        }

        IEnumerator UpdateAch()
        {
            while (true)
            {
                if (Toliviya._army <= 0 && VilitsoMinor._army <= 0)
                {
                    imageComponent1.sprite = Ach1;

                    _victory.text = "Доминирование\n. . .\nВилицианская мощь пала, Толивия в крови - древние империи " +
                        "стерты с лица земли! Теперь ничто не помешает захватить континент!\n";
                }
                else
                {
                    imageComponent1.sprite = Zero;

                    _victory.text = null;
                }

                if (Toliviya._army <= 0 && Serborot._army <= 0 && Tombekiya._army <= 0 && VilitsoMinor._army <= 0)
                {
                    imageComponent2.sprite = Ach2;

                    _harem.text = "Гарем\n. . .\nВаши великие походы привели к тому, что при дворе образовался " +
                        "самый настоящий гарем из принцесс-красавиц!";
                }
                else
                {
                    imageComponent2.sprite = Zero;

                    _harem.text = null;
                }

                yield return new WaitForSeconds(1.5f);
            }
        }
    }
}
