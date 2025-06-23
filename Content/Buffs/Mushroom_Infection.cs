using Terraria;
using Terraria.ModLoader;

namespace TModJam_0.Content.Buffs
{
    internal class Mushroom_Infection : ModBuff
    {

        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true; // This buff can be applied by other players in Pvp, so we need this to be true.
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.swimTime += 1;
            player.waterWalk = true;
        }

    }
}
