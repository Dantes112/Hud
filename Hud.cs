using Rocket.API;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Steamworks;
using NameSpaceID;

namespace Plugin_1
{
    internal class CustomHudWendi : RocketPlugin<HudConfig>
    {
        public static CustomHudWendi Instance;
        private HudConfig cfg;


        protected override void Load()
        {
            Instance = this;
            cfg = CustomHudWendi.Instance.Configuration.Instance;
            U.Events.OnPlayerConnected += Events_OnPlayerConnected;
        }

        protected override void Unload()
        {


        }

        private void Events_OnPlayerConnected(UnturnedPlayer player)
        {
            SetWidgetFlags(player);
            ShowHud(player);
        }

        private void ShowHud(UnturnedPlayer player)
        {
            EffectManager.sendUIEffect(cfg.EffectID, cfg.EffectLayer, player.CSteamID, true);
            if (cfg.ShowEnergy)
            {
                SendVisible("Energy", player, true);
            }
            else
            {
                SendVisible("Energy", player, false);
            }
            if (cfg.ShowHealth)
            {
                SendVisible("Health", player, true);
            }
            else
            {
                SendVisible("Health", player, false);
            }
            if (cfg.ShowFood)
            {
                SendVisible("Food", player, true);
            }
            else
            {
                SendVisible("Food", player, false);
            }
            if (cfg.ShowOxygen)
            {
                SendVisible("Oxygen", player, true);
            }
            else
            {
                SendVisible("Oxygen", player, false);
            }
            if (cfg.ShowVirus)
            {
                SendVisible("Virus", player, true);
            }
            else
            {
                SendVisible("Virus", player, false);
            }
            if (cfg.ShowWater)
            {
                SendVisible("Water", player, true);
            }
            else
            {
                SendVisible("Water", player, false);
            }

        }
        private void SendVisible(string Name, UnturnedPlayer player, bool visible)
        {
            EffectManager.sendUIEffectVisibility(cfg.EffectLayer, player.CSteamID, true, Name+"Bar", visible);
        }
        private void SetWidgetFlags(UnturnedPlayer player)
        {
            player.Player.setPluginWidgetFlag(EPluginWidgetFlags.ShowFood, false);
            player.Player.setPluginWidgetFlag(EPluginWidgetFlags.ShowWater, false);
            player.Player.setPluginWidgetFlag(EPluginWidgetFlags.ShowVirus, false);
            player.Player.setPluginWidgetFlag(EPluginWidgetFlags.ShowStamina, false);
            player.Player.setPluginWidgetFlag(EPluginWidgetFlags.ShowOxygen, false);
            player.Player.setPluginWidgetFlag(EPluginWidgetFlags.ShowHealth, false);
        }
        
    }
}
