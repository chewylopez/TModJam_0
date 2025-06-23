using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TModJam_0.Content.Buffs
{
    internal class Red_Plague : ModBuff
    {

        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.ZoneCorrupt = true;
        }

    }
}