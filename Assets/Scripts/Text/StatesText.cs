using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Assets.Scripts.States
{
    public class StatesText : MonoBehaviour
    {
        [SerializeField] public Text _vilitsoMinorText;
        [SerializeField] public Text _tombekiyaText;

        public void Start()
        {
            StartCoroutine(UpdateStatesText());

            VilitsoMinor._name = PlayerPrefs.GetString("nameVilitso", VilitsoMinor._name);
            VilitsoMinor._money = PlayerPrefs.GetInt("_moneyVilitso", VilitsoMinor._money);
            VilitsoMinor._wood = PlayerPrefs.GetInt("_woodVilitso", VilitsoMinor._wood);
            VilitsoMinor._food = PlayerPrefs.GetInt("_foodVilitso", VilitsoMinor._food);
            VilitsoMinor._army = PlayerPrefs.GetInt("_armyVilitso", VilitsoMinor._army);


            Tombekiya._name = PlayerPrefs.GetString("nameTombekiya", Tombekiya._name);
            Tombekiya._money = PlayerPrefs.GetInt("_moneyTombekiya", Tombekiya._money);
            Tombekiya._wood = PlayerPrefs.GetInt("_woodTombekiya", Tombekiya._wood);
            Tombekiya._food = PlayerPrefs.GetInt("_foodTombekiya", Tombekiya._food);
            Tombekiya._army = PlayerPrefs.GetInt("_armyTombekiya", Tombekiya._army);
        }

        IEnumerator UpdateStatesText()
        {
            while (true)
            {
                _vilitsoMinorText.text = VilitsoMinor.StateText(VilitsoMinor._name, VilitsoMinor._money,
                    VilitsoMinor._wood, VilitsoMinor._food, VilitsoMinor._army);

                _tombekiyaText.text = Tombekiya.StateText(Tombekiya._name, Tombekiya._money, Tombekiya._wood,
                    Tombekiya._food, Tombekiya._army);

                yield return new WaitForSeconds(0.3f);
            }
        }
    }
}
