using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assembly_CSharp
{
    public class TextFood : MonoBehaviour
    {
        [SerializeField] public Text _textFood;

        private void Start()
        {
            StartCoroutine(UpdateFoodText());
        }

        IEnumerator UpdateFoodText()
        {
            while (true)
            {
                _textFood.text = Food._food.ToString();
                yield return new WaitForSeconds(0.3f); // Ожидание одной секунды перед следующим обновлением
            }
        }
    }
}
