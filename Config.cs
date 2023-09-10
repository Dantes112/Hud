using Rocket.API;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using UnityEngine;


namespace NameSpaceID 
{
    public class HudConfig : IRocketPluginConfiguration
    {
        public ushort EffectID;
        public byte EffectLayer;
        public string HealthIcon;
        public string OxygenIcon;
        public string FoodIcon;
        public string VirusIcon;
        public string EnergyIcon;
        public string WaterIcon;


        public bool ShowHealth;
        public bool ShowOxygen;
        public bool ShowFood;
        public bool ShowVirus;
        public bool ShowEnergy;
        public bool ShowWater;


        public bool CustomHealth;
        public bool CustomOxygen;
        public bool CustomFood;
        public bool CustomVirus;
        public bool CustomEnergy;
        public bool CustomWater;

        public void LoadDefaults()
        {
            EffectID = 15555;
            EffectLayer = 55;
            HealthIcon = "YourUrlHere";
            WaterIcon = "YourUrlHere";
            VirusIcon = "YourUrlHere";
            EnergyIcon = "YourUrlHere";
            OxygenIcon = "YourUrlHere";

            ShowHealth = true;
            ShowOxygen = true;
            ShowFood = true;
            ShowVirus = true;
            ShowEnergy = true;
            ShowWater = true;

            CustomEnergy = false;
            CustomWater = false;
            CustomHealth = false;
            CustomFood = false;
            CustomOxygen = false;
            CustomVirus = false;
        }
    }
}
 