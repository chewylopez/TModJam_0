using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria;
using Terraria.GameContent;
using Microsoft.Xna.Framework;

namespace TModJam_0.Content.Items.base_drops
{
    public class Zombie_Blood_Vial : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 26;
            Item.scale = 2f;
            Item.useStyle = ItemUseStyleID.DrinkLiquid;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.rare = ItemRarityID.Green;

            Item.consumable = true;
            Item.value = Item.buyPrice(gold: 1);
            Item.buffType = ModContent.BuffType<Buffs.Undead_Parasite>();
            Item.buffTime = 600;
        }
    }
}
