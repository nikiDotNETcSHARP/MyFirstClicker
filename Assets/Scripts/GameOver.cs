using UnityEditor;
using UnityEngine;

namespace Assets.Scripts
{
    public class GameOver
    {
        static SceneManagement _manager = new();

        public static void OldAgeGameOver()
        {
            _manager.LoadSceneByName("OldAgeEnd");
        }

        public static void MilitaryGameOver()
        {
            _manager.LoadSceneByName("MilitaryGameOver");
        }
    }
}