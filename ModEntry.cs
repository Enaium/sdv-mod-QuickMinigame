using QuickMinigame.Framework;
using QuickMinigame.Framework.Gui;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;

namespace QuickMinigame
{
    public class ModEntry : Mod
    {
        private static ModEntry _instance;
        private Config _config;

        public ModEntry()
        {
            _instance = this;
        }

        public override void Entry(IModHelper helper)
        {
            _config = helper.ReadConfig<Config>();
            helper.Events.Input.ButtonPressed += OnButtonPress;
        }

        private void OnButtonPress(object sender, ButtonPressedEventArgs e)
        {
            if (!Context.IsWorldReady)
                return;
            if (!Context.IsPlayerFree)
                return;
            if (e.Button != _config.OpenQuickMinigame)
                return;
            Game1.activeClickableMenu = new QuickMinigameScreen();
        }

        public static ModEntry GetInstance()
        {
            return _instance;
        }
    }
}