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
        public Sprite sprite3;
        public Sprite sprite4;

        public Image imageComponent;

        private void Start()
        {
            StartCoroutine(UpdatePortrait());

            UpdateTime._gameAge = PlayerPrefs.GetFloat("SavedAge", UpdateTime._gameAge);
        }

        IEnumerator UpdatePortrait()
        {
            while (true)
            {
                switch (UpdateTime._gameAge)
                {
                    case 15:
                        imageComponent.sprite = sprite1;
                        break;
                    case 17:
                        imageComponent.sprite = sprite2;
                        break;
                    case 19:
                        imageComponent.sprite = sprite3;
                        break;
                    case 21:
                        imageComponent.sprite = sprite4;
                        break;
                }

                yield return new WaitForSeconds(1.5f);
            }
        }
    }
}
