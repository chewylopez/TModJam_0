using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace TModJam_0.Content.Buffs
{
    internal class Devils_Deal : ModBuff
    {

        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true; // This buff can be applied by other players in Pvp, so we need this to be true.
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense *= 0f;

            player.GetDamage(DamageClass.Generic) *= 1.5f;
            player.maxRunSpeed *= 1.5f;
            player.statDefense *= 1.5f;
        }

    }
}
