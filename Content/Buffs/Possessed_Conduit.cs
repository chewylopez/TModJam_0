using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TModJam_0.Content.Buffs
{
    internal class Possessed_Conduit : ModBuff
    {

        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true; // This buff can be applied by other players in Pvp, so we need this to be true.
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.onFire = true;
            player.inferno = true;
            NPC.NewNPC(null, (int)player.position.X, (int)player.position.Y, NPCID.Demon);
        }

    }
}
