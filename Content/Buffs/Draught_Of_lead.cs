using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace TModJam_0.Content.Buffs
{
    internal class Draught_Of_Lead : ModBuff
    {

        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 30;

            player.GetDamage(DamageClass.Generic) *= 1.5f;

            player.maxRunSpeed *= 0.5f;
            player.maxFallSpeed += 30;
            player.wingTime -= 100;
        }

    }
}
