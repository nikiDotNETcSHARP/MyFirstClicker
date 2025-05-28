using Assembly_CSharp;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class AgeText : MonoBehaviour
{
    void Start()
    {
        // �������� ������������ ��������
        string savedValue = PlayerPrefs.GetString("SavedText", "");
        _textAge.text = savedValue;

        StartCoroutine(UpdateAgeText());
    }

    [SerializeField] public Text _textAge;

    IEnumerator UpdateAgeText()
    {
        while (true)
        {
            _textAge.text = "�������: " + UpdateAge._gameAge.ToString();
            PlayerPrefs.SetString("SavedText", _textAge.text);
            PlayerPrefs.Save();
            yield return new WaitForSeconds(0.3f); // �������� ����� ������� ����� ��������� �����������
        }
    }

}
