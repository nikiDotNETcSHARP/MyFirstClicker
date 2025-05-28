using Assembly_CSharp;
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
        public Sprite Ach3;
        public Sprite Zero;

        public Image imageComponent1;
        public Image imageComponent2;
        public Image imageComponent3;

        [SerializeField] public Text _victory;
        [SerializeField] public Text _harem;
        [SerializeField] public Text _oldKing;

        private void Start()
        {
            StartCoroutine(UpdateAch());

            VilitsoMinor._army = PlayerPrefs.GetInt("_armyVilitso", VilitsoMinor._army);
            Tombekiya._army = PlayerPrefs.GetInt("_armyTombekiya", Tombekiya._army);
            Serborot._army = PlayerPrefs.GetInt("_armySerborot", Serborot._army);
            Toliviya._army = PlayerPrefs.GetInt("_armyToliviya", Toliviya._army);

            UpdateAge._gameAge = PlayerPrefs.GetFloat("SavedAge", UpdateAge._gameAge);
        }

        IEnumerator UpdateAch()
        {
            while (true)
            {
                if (Toliviya._army <= 0 && VilitsoMinor._army <= 0)
                {
                    imageComponent1.sprite = Ach1;

                    _victory.text = "Доминирование\n. . .\nВилицианская мощь пала, Толивия в крови - древние империи " +
                        "стерты с лица земли! Теперь ничто не помешает захватить континент!";
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

                if (UpdateAge._gameAge >= 50)
                {
                    imageComponent3.sprite = Ach3;

                    _oldKing.text = "Старый король\n. . .\nВремя не щадит никого...\nОсобенно подданных.";
                }
                else
                {
                    imageComponent3.sprite = Zero;

                    _oldKing.text = null;
                }

                yield return new WaitForSeconds(1.5f);
            }
        }
    }
}
