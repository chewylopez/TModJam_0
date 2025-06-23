using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace TModJam_0.Content.Buffs
{
    internal class Frozen_Carapace : ModBuff
    {

        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true; 
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense *= 1.2f;
            player.frozen = true;
        }

    }
}
