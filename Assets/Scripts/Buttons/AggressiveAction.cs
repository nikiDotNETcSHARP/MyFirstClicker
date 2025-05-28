using Assembly_CSharp;
using UnityEngine;

namespace Assets.Scripts.States
{
    public class AggressiveAction : MonoBehaviour
    {
        private MainButtons mainButtons = new MainButtons();

        public void RaidOnVilitso()
        {
            VilitsoMinor.Raid();
            Manpower.Raid();
            if (Manpower._manpower <= 0)
            {
                GameOver.MilitaryGameOver();
                mainButtons.ResetGame();
            }
        }

        public void ScoutingInVilitso()
        {
            if (Manpower._manpower >= 300 && Multiply._peoples >= 300)
            {
                VilitsoMinor.Scouting();
                Manpower.Scouting(300);
                Multiply.Scouting(300);
            }
            if (Manpower._manpower <= 0)
            {
                GameOver.MilitaryGameOver();
                mainButtons.ResetGame();
            }
        }

        public void RaidOnTombekiya()
        {
            Tombekiya.Raid();
            Manpower.Raid();
            if (Manpower._manpower <= 0)
            {
                GameOver.MilitaryGameOver();
                mainButtons.ResetGame();
            }
        }

        public void ScoutingInTombekiya()
        {
            if (Manpower._manpower >= 300 && Multiply._peoples >= 300)
            {
                Tombekiya.Scouting();
                Manpower.Scouting(300);
                Multiply.Scouting(300);
            }
            if (Manpower._manpower <= 0)
            {
                GameOver.MilitaryGameOver();
                mainButtons.ResetGame();
            }
        }

        public void RaidOnSerborot()
        {
            Serborot.Raid();
            Manpower.Raid();
            if (Manpower._manpower <= 0)
            {
                GameOver.MilitaryGameOver();
                mainButtons.ResetGame();
            }
        }

        public void ScoutingInSerborot()
        {
            if (Manpower._manpower >= 300 && Multiply._peoples >= 300)
            {
                Serborot.Scouting();
                Manpower.Scouting(300);
                Multiply.Scouting(300);
            }
            if (Manpower._manpower <= 0)
            {
                GameOver.MilitaryGameOver();
                mainButtons.ResetGame();
            }
        }

        public void RaidOnToliviya()
        {
            Toliviya.Raid();
            Manpower.Raid();
            if (Manpower._manpower <= 0)
            {
                GameOver.MilitaryGameOver();
                mainButtons.ResetGame();
            }
        }

        public void ScoutingInToliviya()
        {
            if (Manpower._manpower >= 300 && Multiply._peoples >= 300)
            {
                Toliviya.Scouting();
                Manpower.Scouting(300);
                Multiply.Scouting(300);
            }
            if (Manpower._manpower <= 0)
            {
                GameOver.MilitaryGameOver();
                mainButtons.ResetGame();
            }
        }
    }
}


