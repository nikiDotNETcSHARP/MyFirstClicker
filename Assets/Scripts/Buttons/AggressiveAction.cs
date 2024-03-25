using Assembly_CSharp;
using UnityEngine;

namespace Assets.Scripts.States
{
    public class AggressiveAction : MonoBehaviour
    {
        public void RaidOnVilitso()
        {
            VilitsoMinor.Raid();
            Manpower.Raid();
        }

        public void ScoutingInVilitso()
        {
            if (Manpower._manpower >= 300 && Multiply._peoples >= 300)
            {
                VilitsoMinor.Scouting();
                Manpower.Scouting(300);
                Multiply.Scouting(300);
            }
        }

        public void RaidOnTombekiya()
        {
            Tombekiya.Raid();
            Manpower.Raid();
        }

        public void ScoutingInTombekiya()
        {
            if (Manpower._manpower >= 300 && Multiply._peoples >= 300)
            {
                Tombekiya.Scouting();
                Manpower.Scouting(300);
                Multiply.Scouting(300);
            }
        }

        public void RaidOnSerborot()
        {
            Serborot.Raid();
            Manpower.Raid();
        }

        public void ScoutingInSerborot()
        {
            if (Manpower._manpower >= 300 && Multiply._peoples >= 300)
            {
                Serborot.Scouting();
                Manpower.Scouting(300);
                Multiply.Scouting(300);
            }
        }

        public void RaidOnToliviya()
        {
            Toliviya.Raid();
            Manpower.Raid();
        }

        public void ScoutingInToliviya()
        {
            if (Manpower._manpower >= 300 && Multiply._peoples >= 300)
            {
                Toliviya.Scouting();
                Manpower.Scouting(300);
                Multiply.Scouting(300);
            }
        }
    }
}


