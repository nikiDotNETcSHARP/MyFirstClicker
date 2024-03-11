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
    public class TextWood : MonoBehaviour
    {
        [SerializeField] public Text _textWood;

        private void Start()
        {
            StartCoroutine(UpdateWoodText());
        }

        IEnumerator UpdateWoodText()
        {
            while (true)
            {
                _textWood.text = Wood._cutWood + "N / " + Wood._wood;
                yield return new WaitForSeconds(0.3f); // Ожидание одной секунды перед следующим обновлением
            }
        }
    }
}
