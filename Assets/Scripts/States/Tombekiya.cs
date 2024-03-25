using Assembly_CSharp;
using UnityEngine;

namespace Assets.Scripts.States
{
    public class Tombekiya
    {
        public static string _name = "Томбекия";
        public static int _money = 500;
        public static int _wood = 100;
        public static int _food = 150;
        public static int _army = 400;
        public static int _switcher = 0;

        public static string StateText(int money, int wood, int food, int army)
        {
            if (_switcher == 1 || _money == 0 && _wood == 0 && _food == 0 && _army == 0)
            {
                string text = $"Золото: {money}\nДревесина: {wood}\n" +
                    $"Припасы: {food}\nВойско: {army}\n";
                return text;
            }
            else
            {
                string text2 = $"Золото: ?\nДревесина: ?\nПрипасы: ?\nВойско: ?\n";
                return text2;
            }
        }

        public static void Raid()
        {
            int modifier = _army;

            _army -= Manpower._manpower;
            Manpower._manpower -= modifier;

            PlayerPrefs.SetInt("_armyTombekiya", _army);
            PlayerPrefs.SetInt("_manpower", Manpower._manpower);

            if (_army < 0)
            {
                _army = 0;
                PlayerPrefs.SetInt("_armyTombekiya", _army);

                if (_money > 0)
                {
                    Money._money += _money;
                    PlayerPrefs.SetInt("money", Money._money);

                    _money = 0;
                    PlayerPrefs.SetInt("_moneyTombekiya", _money);
                }
                else
                {
                    _money = 0;
                    PlayerPrefs.SetInt("_moneyTombekiya", _money);
                }

                if (_wood > 0)
                {
                    Wood._wood += _wood;
                    PlayerPrefs.SetInt("wood", Wood._wood);

                    _wood = 0;
                    PlayerPrefs.SetInt("_woodTombekiya", _wood);
                }
                else
                {
                    _wood = 0;
                    PlayerPrefs.SetInt("_woodTombekiya", _wood);
                }

                if (_food > 0)
                {
                    Food._food += _food;
                    PlayerPrefs.SetInt("_food", Food._food);

                    _food = 0;
                    PlayerPrefs.SetInt("_foodTombekiya", _food);
                }
                else
                {
                    _food = 0;
                    PlayerPrefs.SetInt("_foodTombekiya", _food);
                }
            }
        }

        public static void Scouting()
        {
            _switcher = 1;
            PlayerPrefs.SetInt("_switcherTombekiya", _switcher);
        }

        public static void Reset()
        {
            _money = 500;
            _wood = 100;
            _food = 150;
            _army = 400;

            PlayerPrefs.SetInt("_moneyTombekiya", _money);
            PlayerPrefs.SetInt("_woodTombekiya", _wood);
            PlayerPrefs.SetInt("_foodTombekiya", _food);
            PlayerPrefs.SetInt("_armyTombekiya", _army);
        }
    }
}
