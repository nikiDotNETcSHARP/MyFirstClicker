using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.States.AggressiveForeignActions
{
    public class AttackOnHero : MonoBehaviour
    {
        public GameObject notificationPanel;
        public Text notificationText;
        public float notificationInterval = 10f;

        private void Awake()
        {
            // Сохраняем объект при переходе между сценами
            DontDestroyOnLoad(gameObject);
        }

        private void Start()
        {
            // Начинаем корутину для показа оповещений
            StartCoroutine(ShowPeriodicNotification());
        }

        private IEnumerator ShowPeriodicNotification()
        {
            while (true)
            {
                yield return new WaitForSeconds(notificationInterval);
                ShowNotification("Периодическое оповещение!");
            }
        }

        private void ShowNotification(string message)
        {
            if (notificationPanel != null && notificationText != null)
            {
                notificationText.text = message;
                notificationPanel.SetActive(true);

                // Скрываем панель через несколько секунд
                StartCoroutine(HideNotificationAfterDelay(5f));
            }
        }

        private IEnumerator HideNotificationAfterDelay(float delay)
        {
            yield return new WaitForSeconds(delay);
            if (notificationPanel != null)
            {
                notificationPanel.SetActive(false);
            }
        }
    }
}