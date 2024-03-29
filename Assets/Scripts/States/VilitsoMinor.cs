﻿using Assembly_CSharp;
using UnityEngine;

namespace Assets.Scripts.States
{
    public class VilitsoMinor
    {
        public static string _name = "Малое Вилицо";
        public static int _money = 2000;
        public static int _wood = 1000;
        public static int _food = 1500;
        public static int _army = 1500;
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

            PlayerPrefs.SetInt("_armyVilitso", _army);
            PlayerPrefs.SetInt("_manpower", Manpower._manpower);

            if (_army < 0)
            {
                _army = 0;
                PlayerPrefs.SetInt("_armyVilitso", _army);

                if (_money > 0)
                {
                    Money._money += _money;
                    PlayerPrefs.SetInt("money", Money._money);

                    _money = 0;
                    PlayerPrefs.SetInt("_moneyVilitso", _money);
                }
                else
                {
                    _money = 0;
                    PlayerPrefs.SetInt("_moneyVilitso", _money);
                }

                if (_wood > 0)
                {
                    Wood._wood += _wood;
                    PlayerPrefs.SetInt("wood", Wood._wood);

                    _wood = 0;
                    PlayerPrefs.SetInt("_woodVilitso", _wood);
                }
                else
                {
                    _wood = 0;
                    PlayerPrefs.SetInt("_woodVilitso", _wood);
                }

                if (_food > 0)
                {
                    Food._food += _food;
                    PlayerPrefs.SetInt("_food", Food._food);

                    _food = 0;
                    PlayerPrefs.SetInt("_foodVilitso", _food);
                }
                else
                {
                    _food = 0;
                    PlayerPrefs.SetInt("_foodVilitso", _food);
                }
            }
        }

        public static void Scouting()
        {
            _switcher = 1;
            PlayerPrefs.SetInt("_switcherVilitso", _switcher);
        }

        public static void Reset()
        {
            _money = 2000;
            _wood = 1000;
            _food = 1500;
            _army = 1500;

            PlayerPrefs.SetInt("_moneyVilitso", _money);
            PlayerPrefs.SetInt("_woodVilitso", _wood);
            PlayerPrefs.SetInt("_foodVilitso", _food);
            PlayerPrefs.SetInt("_armyVilitso", _army);
        }
    }
}
