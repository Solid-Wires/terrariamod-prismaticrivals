using Terraria;
using Terraria.Localization;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace PrismaticRivals.Debug
{
    class CommandSpawnNPC : ModCommand
    {
        public override string Command => "spawnprismnpc";

        public override CommandType Type => CommandType.World;

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            if (caller.Player != null)
            {
                caller.Player.KillMe(PlayerDeathReason.ByCustomReason("Oops! This command isn't finished."), 100, 0);
                if (args.Length == 1)
                {
                    string a0 = args[0];
                }
                else
                {
                    caller.Reply("Command expects 1 argument", Microsoft.Xna.Framework.Color.Red);
                }
            }
        }
    }
}
