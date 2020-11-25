using EnaiumToolKit.Framework.Screen;
using EnaiumToolKit.Framework.Screen.Elements;
using StardewValley;
using StardewValley.Minigames;

namespace QuickMinigame.Framework.Gui
{
    public class QuickMinigameScreen : ScreenGui
    {
        public QuickMinigameScreen()
        {
            AddElement(new Button(
                $"{GetTranslation("quickMinigame.button")} {GetTranslation("quickMinigame.button.slots")}",
                $"{GetTranslation("quickMinigame.button")} {GetTranslation("quickMinigame.button.slots")}")
            {
                OnLeftClicked = () => { Game1.currentMinigame = new Slots(); }
            });
            AddElement(new Button(
                $"{GetTranslation("quickMinigame.button")} {GetTranslation("quickMinigame.button.prairieKing")}",
                $"{GetTranslation("quickMinigame.button")} {GetTranslation("quickMinigame.button.prairieKing")}")
            {
                OnLeftClicked = () => { Game1.currentMinigame = new AbigailGame(); }
            });
            AddElement(new Button(
                $"{GetTranslation("quickMinigame.button")} {GetTranslation("quickMinigame.button.calicoJack")}",
                $"{GetTranslation("quickMinigame.button")} {GetTranslation("quickMinigame.button.calicoJack")}")
            {
                OnLeftClicked = () => { Game1.currentMinigame = new CalicoJack(); }
            });
            AddElement(new Button(
                $"{GetTranslation("quickMinigame.button")} {GetTranslation("quickMinigame.button.craneGame")}",
                $"{GetTranslation("quickMinigame.button")} {GetTranslation("quickMinigame.button.craneGame")}")
            {
                OnLeftClicked = () => { Game1.currentMinigame = new CraneGame(); }
            });
            AddElement(new Button(
                $"{GetTranslation("quickMinigame.button")} {GetTranslation("quickMinigame.button.minecartProgressMode")}",
                $"{GetTranslation("quickMinigame.button")} {GetTranslation("quickMinigame.button.minecartProgressMode")}")
            {
                OnLeftClicked = () => { Game1.currentMinigame = new MineCart(0, 3); }
            });
            AddElement(new Button(
                $"{GetTranslation("quickMinigame.button")} {GetTranslation("quickMinigame.button.minecartEndlessMode")}",
                $"{GetTranslation("quickMinigame.button")} {GetTranslation("quickMinigame.button.minecartEndlessMode")}")
            {
                OnLeftClicked = () => { Game1.currentMinigame = new MineCart(0, 2); }
            });
        }

        private string GetTranslation(string key)
        {
            return ModEntry.GetInstance().Helper.Translation.Get(key);
        }
    }
}