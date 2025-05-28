using Assets.Scripts.States;
using System.Collections;
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

        [SerializeField] public Text _textPrincess1;
        [SerializeField] public Text _textPrincess2;
        [SerializeField] public Text _textPrincess3;
        [SerializeField] public Text _textPrincess4;

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

                    _textPrincess1.text = "Лаура Томбекийская\n. . .\n С победой династии Райз в Толивии, Лаура из герцогской дочери стала принцессой. Девушка должна была выйти за " +
                        "наследного принца Толивийского, как главного союзника Томбекии. Но, конечно же, этому помешал ваш поход, заставивший принцессу изменить планы по поводу " +
                        "личной жизни.";
                }
                else
                {
                    _princess1.sprite = _zeroPrincess;
                }


                if (Serborot._army <= 0)
                {
                    _princess2.sprite = _serborotPrincess;

                    _textPrincess2.text = "Айла-еретичка\n. . .\n После опустошающего похода Вилицо на Серборот, потомки выжженного царства подыграли обвинениям в еретизме, " +
                        "надеясь сплотить разрушенную страну. Айла - последний монарх-иноверец, после вашего похода теперь проводит время в саду, чего ей так не хватало " +
                        "в пустынном Сербороте.";
                }
                else
                {
                    _princess2.sprite = _zeroPrincess;
                }


                if (Toliviya._army <= 0)
                {
                    _princess3.sprite = _toliviyaPrincess;

                    _textPrincess3.text = "Сара Августа фитц Райз\n. . .\n Властолюбивая принцесса Королевства Толивия - страны, разрушившей Великое Вилицо в ходе войны за " +
                        "независимость. Высокомерна и крайне жестока к своим врагам. Понадобилось немало воинов, чтобы усмирить ее гвардию, но в конце концов даже львица-Райз " +
                        "оказалась под вашей властью. Хе-хе.";
                }
                else
                {
                    _princess3.sprite = _zeroPrincess;
                }


                if (VilitsoMinor._army <= 0)
                {
                    _princess4.sprite = _vilitsoPrincess;

                    _textPrincess4.text = "Шарлотта ван Арктур\n. . .\n Импертрица ван Арктур не обладает реальной властью в Вилицо и вынуждена потакать " +
                        "могущественным вассалам. Шарлотта в глазах людей - воплощение Бога. Ее красота ослепительна. Даже после вашей победы вилицианцы продолжают отчаянно " +
                        "сопротивляться... но это ненадолго.";
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
