using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TModJam_0.Content.Buffs
{
    internal class Honey_Inoculation : ModBuff
    {

        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true; // This buff can be applied by other players in Pvp, so we need this to be true.
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.honey = true;

            for (int i = 0; i < 2; i++) {
                NPC.NewNPC(null, (int)player.position.X, (int)player.position.Y, NPCID.BeeSmall);
            }

        }

    }
}
