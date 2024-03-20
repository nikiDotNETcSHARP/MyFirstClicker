using Assembly_CSharp;
using Assets.Scripts.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.States
{
    public class AggressiveAction : MonoBehaviour
    {
        public void RaidOnState()
        {
            VilitsoMinor.Raid();
            Manpower.Raid();
        }

        public static void ScoutingStates()
        {
            if (Manpower._manpower >= 300 && Multiply._peoples >= 300)
            {
                VilitsoMinor.Scouting();
                Manpower.Scouting(300);
                Multiply.Scouting(300);
            }
        }
    }
}


