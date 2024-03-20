using Assembly_CSharp;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Portrait : MonoBehaviour
    {
        public Sprite sprite1;
        public Sprite sprite2;

        public Image imageComponent;

        private void Start()
        {
            StartCoroutine(UpdatePortrait());

            UpdateTime.instance._gameAge = PlayerPrefs.GetFloat("SavedAge", UpdateTime.instance._gameAge);
        }

        IEnumerator UpdatePortrait()
        {
            while (true)
            {
                if (UpdateTime.instance._gameAge >= 15 && UpdateTime.instance._gameAge < 16)
                {
                    imageComponent.sprite = sprite1;
                }
                else if (UpdateTime.instance._gameAge >= 16)
                {
                    imageComponent.sprite = sprite2;
                }
                yield return new WaitForSeconds(1.5f);
            }
        }
    }
}
