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
        [SerializeField] public Text _tombekiyaText;
        [SerializeField] public Text _serborotText;
        [SerializeField] public Text _toliviyaText;

        public void Start()
        {
            StartCoroutine(UpdateStatesText());

            //Данные Вилицо
            VilitsoMinor._money = PlayerPrefs.GetInt("_moneyVilitso", VilitsoMinor._money);
            VilitsoMinor._wood = PlayerPrefs.GetInt("_woodVilitso", VilitsoMinor._wood);
            VilitsoMinor._food = PlayerPrefs.GetInt("_foodVilitso", VilitsoMinor._food);
            VilitsoMinor._army = PlayerPrefs.GetInt("_armyVilitso", VilitsoMinor._army);

            //Данные Томбекии
            Tombekiya._money = PlayerPrefs.GetInt("_moneyTombekiya", Tombekiya._money);
            Tombekiya._wood = PlayerPrefs.GetInt("_woodTombekiya", Tombekiya._wood);
            Tombekiya._food = PlayerPrefs.GetInt("_foodTombekiya", Tombekiya._food);
            Tombekiya._army = PlayerPrefs.GetInt("_armyTombekiya", Tombekiya._army);

            //Данные Серборота
            Serborot._money = PlayerPrefs.GetInt("_moneySerborot", Serborot._money);
            Serborot._wood = PlayerPrefs.GetInt("_woodSerborot", Serborot._wood);
            Serborot._food = PlayerPrefs.GetInt("_foodSerborot", Serborot._food);
            Serborot._army = PlayerPrefs.GetInt("_armySerborot", Serborot._army);

            //Данные Толивии
            Toliviya._money = PlayerPrefs.GetInt("_moneyToliviya", Toliviya._money);
            Toliviya._wood = PlayerPrefs.GetInt("_woodToliviya", Toliviya._wood);
            Toliviya._food = PlayerPrefs.GetInt("_foodToliviya", Toliviya._food);
            Toliviya._army = PlayerPrefs.GetInt("_armyToliviya", Toliviya._army);
        }

        IEnumerator UpdateStatesText()
        {
            while (true)
            {
                _vilitsoMinorText.text = VilitsoMinor.StateText(VilitsoMinor._money,
                    VilitsoMinor._wood, VilitsoMinor._food, VilitsoMinor._army);

                _tombekiyaText.text = Tombekiya.StateText(Tombekiya._money, Tombekiya._wood,
                    Tombekiya._food, Tombekiya._army);

                _serborotText.text = Serborot.StateText(Serborot._money, Serborot._wood,
                    Serborot._food, Serborot._army);

                _toliviyaText.text = Toliviya.StateText(Toliviya._money, Toliviya._wood,
                    Toliviya._food, Toliviya._army);

                yield return new WaitForSeconds(0.3f);
            }
        }
    }
}
