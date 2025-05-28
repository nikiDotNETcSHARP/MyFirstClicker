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

        private void Awake()
        {
            // Сохраняем объект при переходе между сценами
            DontDestroyOnLoad(gameObject);
        }

        private void Start()
        {
            UpdateAge._gameAge = PlayerPrefs.GetFloat("SavedAge", UpdateAge._gameAge);

            UpdatePortraitImage();

            StartCoroutine(UpdatePortrait());
        }

        IEnumerator UpdatePortrait()
        {
            while (true)
            {
                UpdatePortraitImage();
                yield return new WaitForSeconds(1.5f);
            }
        }

        private void UpdatePortraitImage()
        {
            if (UpdateAge._gameAge >= 15 && UpdateAge._gameAge < 17)
            {
                imageComponent.sprite = sprite1;
            }
            else if (UpdateAge._gameAge >= 17 && UpdateAge._gameAge < 35)
            {
                imageComponent.sprite = sprite2;
            }
            else if (UpdateAge._gameAge >= 35 && UpdateAge._gameAge < 50)
            {
                imageComponent.sprite = sprite3;
            }
            else if (UpdateAge._gameAge >= 50)
            {
                imageComponent.sprite = sprite4;
            }
        }
    }
}
