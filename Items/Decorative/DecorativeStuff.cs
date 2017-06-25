using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items.Decorative {
public class DecorativeAmethystStaff : ModItem
{
    public override void SetDefaults()
    {
        item.width = 12;
        item.height = 12;
        item.maxStack = 999;
        item.useTurn = true;
        item.autoReuse = true;
        item.useAnimation = 15;
        item.useTime = 7;
        item.useStyle = 1;
        item.consumable = true;
		item.createTile = mod.TileType("AmethystStaff");
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.AmethystStaff, 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
    }
	public class DecorativeAmberStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("AmberStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AmberStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeAle : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Ale");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ale, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeAbeemination : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Abeemination");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Abeemination, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeWormholePotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("WormholePotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WormholePotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeWormFood : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("WormFood");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WormFood, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeWine : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Wine");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"Wine", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeWheatBread : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("WheatBread");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"WheatBread", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeWaterWalkingPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("WaterWalkingPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WaterWalkingPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeWatermelon : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Watermelon");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"Watermelon", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeWaterBolt : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("WaterBolt");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WaterBolt, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeWarmthPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("WarmthPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WarmthPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeWandofSparking : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("WandofSparking");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WandofSparking, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeVileThorn : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("VileThorn");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Vilethorn, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeVilePowder : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("VilePowder");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.VilePowder, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeVileMushroom : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("VileMushroom");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.VileMushroom, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeViciousPowder : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("ViciousPowder");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ViciousPowder, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeViciousMushroom : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("ViciousMushroom");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ViciousMushroom, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeVenomStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("VenomStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.VenomStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeUnholyWater : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("UnholyWater");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.UnholyWater, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeUnholyTrident : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("UnholyTrident");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.UnholyTrident, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeTulipWand: ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("TulipWand");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"TulipWand", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeTreasureMap : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("TreasureMap");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PirateMap, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeTopazStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("TopazStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TopazStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeTitanPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("TitanPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TitanPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeThornsPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("ThornsPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ThornsPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeTempestStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("TempestStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TempestStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeTeleportationPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("TeleportationPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TeleportationPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeSwiftnessPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("SwiftnessPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SwiftnessPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeSuperManaPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("SuperManaPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SuperManaPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeSuperHealingPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("SuperHealingPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SuperHealingPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeSummoningPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("SummoningPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SummoningPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeSugarCookie : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("SugarCookie");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SugarCookie, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeStrangeBrew : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("StrangeBrew");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StrangeBrew, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeStinkPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("StinkPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StinkPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeStickyGrenade : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("StickyGrenade");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StickyGrenade, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeStickyDynamite : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("StickyDynamite");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StickyDynamite, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeStardustDragonStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("StardustDragonStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StardustDragonStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeStaffOfTheFrostHydra : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("StaffOfTheFrostHydra");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StaffoftheFrostHydra, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeShinePotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("ShinePotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ShinePotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeSashimi : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Sashimi");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Sashimi, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeRainbowCrystalStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("RainbowCrystalStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RainbowCrystalStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeMeteorStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("MeteorStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MeteorStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeStickyBomb : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("StickyBomb");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StickyBomb, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeStarRod : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("StarRod");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"StarRod", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeStardustCellStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("StardustCellStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StardustCellStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeStaffOfEarth : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("StaffOfEarth");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StaffofEarth, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeSpiderStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("SpiderStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpiderStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeSpelunkerPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("SpelunkerPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpelunkerPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeSpectreStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("SpectreStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpectreStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeSoupPot : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("SoupPot");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"SoupPot", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeSoup : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("BowlOfSoup");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BowlofSoup, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeSonarPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("SonarPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SonarPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeSolarTablet : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("SolarTablet");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SolarTablet, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeSnowglobe : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Snowglobe");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SnowGlobe, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeSlimeStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("SlimeStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SlimeStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeSlimeCrown : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("SlimeCrown");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SlimeCrown, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeSkyFracture : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("SkyFracture");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SkyFracture, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeShadowbeamStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("ShadowbeamStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ShadowbeamStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeFlaskofNanites : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("FlaskNanites");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FlaskofNanites, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeFlaskofGold : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("FlaskGold");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FlaskofGold, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeRagePotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("RagePotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RagePotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeSEye : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("SuspiciousEye");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SuspiciousLookingEye, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeSapphireStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("SapphireStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SapphireStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeSake : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Sake");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Sake, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeRyeBread : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("RyeBread");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"RyeBread", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeRubyStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("RubyStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RubyStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeRoseWand : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("RoseWand");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"RoseWand", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeRoseThorn : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("RoseThorn");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"RoseThorn", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeRestorationPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("RestorationPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RestorationPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeRegenerationPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("RegenerationPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RegenerationPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeRecallPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("RecallPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RecallPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeRazorBladeTyphoon : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("RazorBladeTyphoon");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RazorbladeTyphoon, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeRavenStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("RavenStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RavenStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeRainbowRod : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("RainbowRod");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RainbowRod, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeQueenSpiderStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("SpiderQueenStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.QueenSpiderStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativePygmyStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("PygmyStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PygmyStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativePurificationPowder : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("PurificationPowder");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PurificationPowder, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativePumpkinPie : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("PumpkinPie");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PumpkinPie, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativePumpkinMedallion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("PumpkinMedallion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PumpkinMoonMedallion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativePowerCell : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("PowerCell");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LihzahrdPowerCell, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativePoisonStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("PoisonStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PoisonStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativePirateStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("PirateStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PirateStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativePinaColada : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("PinaColada");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"PinaColada", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativePho : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Pho");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Pho, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativePadThai : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("PadThai");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PadThai, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeOrange : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Orange");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"Orange", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeOpticStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("OpticStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.OpticStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeObsidianSkinPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("ObsidianSkinPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ObsidianSkinPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeNimbusRod : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("NimbusRod");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.NimbusRod, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeNightOwlPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("NightOwlPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.NightOwlPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeNaughtyPresent : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("NaughtyPresent");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.NaughtyPresent, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeMushroom : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Mushroom");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Mushroom, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeMiningPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("MiningPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MiningPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeMechWorm : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("MechanicalWorm");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MechanicalWorm, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeMechSkull : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("MechanicalSkull");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MechanicalSkull, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeMechEye : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("MechanicalEye");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MechanicalEye, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeManaRegenerationPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("ManaRegenerationPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ManaRegenerationPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeManaPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("ManaPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ManaPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeManaCrystal : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("ManaCrystal");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ManaCrystal, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeMagnetSphere : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("MagnetSphere");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MagnetSphere, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeMagicPowerPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("MagicPowerPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MagicPowerPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeMagicMissile : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("MagicMissile");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MagicMissile, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeMagicMirror : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("MagicMirror");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MagicMirror, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeMagicHat : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("MagicHat");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"MagicianHat", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeMagicalHarp : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("MagicalHarp");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MagicalHarp, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeLunarPortalStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("LunarPortal");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MoonlordTurretStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeLunarFlare : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("LunarFlare");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarFlareBook, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeLovePotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("LovePotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LovePotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeLifeforcePotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("LifeforcePotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LifeforcePotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeLifeDrain : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("LifeDrain");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulDrain, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeLesserRestorationPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("LesserRestorationPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LesserRestorationPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeLesserManaPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("LesserManaPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LesserManaPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeLesserHealingPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("LesserHealingPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LesserHealingPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeLemonBar : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("LemonBar");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"LemonBar", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeLemonade : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Lemonade");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"Lemonade", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeLemon : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Lemon");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"Lemon", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeLastPrism : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("LastPrism");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LastPrism, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeJam : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Jam");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"Jam", 1);
			recipe.AddTile(null,"CanningStation");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeIronskinPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("IronskinPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronskinPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeIrisWand: ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("IrisWand");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"IrisWand", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeInvisibilityPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("InvisibilityPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.InvisibilityPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeInfernoPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("InfernoPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.InfernoPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeInfernoFork : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("InfernoFork");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.InfernoFork, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeImpStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("ImpStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ImpStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeIceRod : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("IceRod");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceRod, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeIceMirror : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("IceMirror");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceMirror, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeHunterPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("HunterPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HunterPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeHornetStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("HornetStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HornetStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeHolyWater : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("HolyWater");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HolyWater, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeHeartreachPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("HeartreachPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HeartreachPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeHealingPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("HealingPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HealingPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeHarp : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Harp");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Harp, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeGravitationPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("GravitationPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GravitationPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeDeadlySphereStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("DeadlySphereStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DeadlySphereStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeCratePotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("CratePotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CratePotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeBlastCannon : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("BlastCannon");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChargedBlasterCannon, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeBell : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Bell");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bell, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeHappyGrenade : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("HappyGrenade");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PartyGirlGrenade, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeGrubSoup : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("GrubSoup");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GrubSoup, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeGrenade : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Grenade");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Grenade, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeGreaterManaPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("GreaterManaPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GreaterManaPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeGreaterHealingPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("GreaterHealingPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GreaterHealingPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeGoldenShower : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("GoldenShower");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenShower, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeGoblinBattleStandard : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("GoblinBattleStandard");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoblinBattleStandard, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeGingerbreadCookie : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("GingerbreadCookie");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GingerbreadCookie, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeGillsPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("GillsPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GillsPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeGenderChangePotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("GenderChangePotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GenderChangePotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeFrostFlower : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("FrostFlower");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FlowerofFrost, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeFlowerrificWand: ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("FlowerrificWand");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"FlowerreficWand", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeFlipperPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("FlipperPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FlipperPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeFlaskofVenom : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("FlaskVenom");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FlaskofVenom, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeFlaskofPoison : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("FlaskPoison");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FlaskofPoison, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeFlaskofParty : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("FlaskParty");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FlaskofParty, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeFlaskofIchor : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("FlaskIchor");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FlaskofIchor, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeFlaskofFire : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("FlaskFire");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FlaskofFire, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeFlaskofCursedFlames : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("FlaskCursedFlames");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FlaskofCursedFlames, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeFlameLash : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("FlameLash");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Flamelash, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeFishStick : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("FishStick");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"FishStick", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeFishingPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("FishingPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FishingPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeFireFlower : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("FireFlower");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FlowerofFire, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeFeatherfallPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("FeatherfallPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FeatherfallPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeFallenStar : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("FallenStar");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FallenStar, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeFairyBell : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("FairyBell");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FairyBell, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeEquinoxLantern : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("EquinoxLantern");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"EquinoxLantern", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeEndurancePotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("EndurancePotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.EndurancePotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeEmeraldStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("EmeraldStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.EmeraldStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeEggnog : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Eggnog");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Eggnog, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeEgg : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 15;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Egg");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"Egg", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeDynamite : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Dynamite");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Dynamite, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeDiamondStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("DiamondStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DiamondStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeDemonScythe : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("DemonScythe");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemonScythe, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeDangersensePotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("DangersensePotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TrapsightPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeCursedFlames : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("CursedFlames");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CursedFlames, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeCrystalStorm : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("CrystalStorm");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrystalStorm, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeCrimsonRod : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("CrimsonRod");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrimsonRod, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeCookedShrimp : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("CookedShrimp");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CookedShrimp, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeCookedMarshmallow : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("CookedMarshmallow");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CookedMarshmallow, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeCookedFish : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("CookedFish");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CookedFish, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeCompleteBreakfast : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("CompleteBreakfast");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"CompleteBreakfast", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeCoffee : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Coffee");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"Coffee", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeClingerStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("ClingerStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ClingerStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeChristmasPudding : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("ChristmasPudding");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChristmasPudding, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
		public class DecorativeCherryPie : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("CherryPie");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"CherryPie", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeCherry : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 30;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Cherry");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"Cherry", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();    
		}
	}
	public class DecorativeCelestialSigil : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("CelestialSigil");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CelestialSigil, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeCalmingPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("CalmingPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CalmingPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeBuilderPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("BuilderPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BuilderPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeBouncyGrenade : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("BouncyGrenade");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BouncyGrenade, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeBouncyDynamite : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("BouncyDynamite");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BouncyDynamite, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeBouncyBomb : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("BouncyBomb");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BouncyBomb, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeBottledWater : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("BottledWater");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeBottledHoney : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("BottledHoney");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledHoney, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeBookOfSkulls : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("BookOfSkulls");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BookofSkulls, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeBomb : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Bomb");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bomb, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeBloodySpine : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("BloodySpine");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BloodySpine, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeBloodWater : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("BloodWater");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BloodWater, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeBlizzardStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("BlizzardStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BlizzardStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeBeenade : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Beenade");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Beenade, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeBattlePotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("BattlePotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BattlePotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeBatSceptre : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("BatSceptre");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BatScepter, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeBacon : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Bacon");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bacon, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeArcheryPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("ArcheryPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ArcheryPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeAquaSceptre : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("AquaSceptre");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AquaScepter, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeApplePie : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("ApplePie");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"ApplePie", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeAppleJuice : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("AppleJuice");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"AppleJuice", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeApple : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Apple");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"Apple", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeAmmoReservationPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("AmmoReservationPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AmmoReservationPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeWrathPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("WrathPotion");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WrathPotion, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeXenoStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("XenoStaff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.XenoStaff, 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
	public class DecorativeHotPepper : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("HotPepper");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"HotPepper", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
		public class DecorativeAshPotato : ModItem
		{
			public override void SetDefaults()
			{
				item.width = 12;
				item.height = 12;
				item.maxStack = 999;
				item.useTurn = true;
				item.autoReuse = true;
				item.useAnimation = 15;
				item.useTime = 7;
				item.useStyle = 1;
				item.consumable = true;
				item.createTile = mod.TileType("Potato");
			}

			public override void AddRecipes()
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(null,"AshPotato", 1);
				recipe.AddTile(null,"SculptingStand");
				recipe.SetResult(this, 1);
				recipe.AddRecipe();
			}
		}
		public class DecorativeHellfries : ModItem
		{
			public override void SetDefaults()
			{
				item.width = 12;
				item.height = 12;
				item.maxStack = 999;
				item.useTurn = true;
				item.autoReuse = true;
				item.useAnimation = 15;
				item.useTime = 7;
				item.useStyle = 1;
				item.consumable = true;
				item.createTile = mod.TileType("Hellfries");
			}

			public override void AddRecipes()
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(null,"Hellfries", 1);
				recipe.AddTile(null,"SculptingStand");
				recipe.SetResult(this, 1);
				recipe.AddRecipe();
			}
		}
		public class DecorativeSpicyHellfries : ModItem
		{
			public override void SetDefaults()
			{
				item.width = 12;
				item.height = 12;
				item.maxStack = 999;
				item.useTurn = true;
				item.autoReuse = true;
				item.useAnimation = 15;
				item.useTime = 7;
				item.useStyle = 1;
				item.consumable = true;
				item.createTile = mod.TileType("SpicyHellfries");
			}

			public override void AddRecipes()
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(null,"HotNSpicyFries", 1);
				recipe.AddTile(null,"SculptingStand");
				recipe.SetResult(this, 1);
				recipe.AddRecipe();
			}
		}
		public class DecorativeIceCream : ModItem
		{
			public override void SetDefaults()
			{
				item.width = 12;
				item.height = 12;
				item.maxStack = 999;
				item.useTurn = true;
				item.autoReuse = true;
				item.useAnimation = 15;
				item.useTime = 7;
				item.useStyle = 1;
				item.consumable = true;
				item.createTile = mod.TileType("IceCream");
			}

			public override void AddRecipes()
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(null,"IceCream", 1);
				recipe.AddTile(null,"SculptingStand");
				recipe.SetResult(this, 1);
				recipe.AddRecipe();
			}
		}
		public class DecorativeCelestialMilkshake : ModItem
		{
			public override void SetDefaults()
			{
				item.width = 12;
				item.height = 12;
				item.maxStack = 999;
				item.useTurn = true;
				item.autoReuse = true;
				item.useAnimation = 15;
				item.useTime = 7;
				item.useStyle = 1;
				item.consumable = true;
				item.createTile = mod.TileType("CelestialMilkshake");
			}

			public override void AddRecipes()
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(null,"CelestialMilkshake", 1);
				recipe.AddTile(null,"SculptingStand");
				recipe.SetResult(this, 1);
				recipe.AddRecipe();
			}
		}
		public class DecorativeMilk : ModItem
		{
			public override void SetDefaults()
			{
				item.width = 12;
				item.height = 12;
				item.maxStack = 999;
				item.useTurn = true;
				item.autoReuse = true;
				item.useAnimation = 15;
				item.useTime = 7;
				item.useStyle = 1;
				item.consumable = true;
				item.createTile = mod.TileType("Milk");
			}

			public override void AddRecipes()
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(null,"Milk", 1);
				recipe.AddTile(null,"SculptingStand");
				recipe.SetResult(this, 1);
				recipe.AddRecipe();
			}
		}
		public class DecorativeStarrySyrup : ModItem
		{
			public override void SetDefaults()
			{
				item.width = 12;
				item.height = 12;
				item.maxStack = 999;
				item.useTurn = true;
				item.autoReuse = true;
				item.useAnimation = 15;
				item.useTime = 7;
				item.useStyle = 1;
				item.consumable = true;
				item.createTile = mod.TileType("StarrySyrup");
			}

			public override void AddRecipes()
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(null,"StarrySyrup", 1);
				recipe.AddTile(null,"SculptingStand");
				recipe.SetResult(this, 1);
				recipe.AddRecipe();
			}
		}
		public class DecorativeLotusWand : ModItem
		{
			public override void SetDefaults()
			{
				item.width = 12;
				item.height = 12;
				item.maxStack = 999;
				item.useTurn = true;
				item.autoReuse = true;
				item.useAnimation = 15;
				item.useTime = 7;
				item.useStyle = 1;
				item.consumable = true;
				item.createTile = mod.TileType("LotusWand");
			}

			public override void AddRecipes()
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(null,"LotusWand", 1);
				recipe.AddTile(null,"SculptingStand");
				recipe.SetResult(this, 1);
				recipe.AddRecipe();
			}
		}
		public class DecorativeTigerlilyWand : ModItem
		{
			public override void SetDefaults()
			{
				item.width = 12;
				item.height = 12;
				item.maxStack = 999;
				item.useTurn = true;
				item.autoReuse = true;
				item.useAnimation = 15;
				item.useTime = 7;
				item.useStyle = 1;
				item.consumable = true;
				item.createTile = mod.TileType("TigerlilyWand");
			}

			public override void AddRecipes()
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(null,"TigerlilyWand", 1);
				recipe.AddTile(null,"SculptingStand");
				recipe.SetResult(this, 1);
				recipe.AddRecipe();
			}
		}
		public class DecorativeGlowstick : ModItem
		{
			public override void SetDefaults()
			{
				item.width = 12;
				item.height = 12;
				item.maxStack = 999;
				item.useTurn = true;
				item.autoReuse = true;
				item.useAnimation = 15;
				item.useTime = 7;
				item.useStyle = 1;
				item.consumable = true;
				item.createTile = mod.TileType("Glowstick");
			}

			public override void AddRecipes()
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.Glowstick, 1);
				recipe.AddTile(null,"SculptingStand");
				recipe.SetResult(this, 1);
				recipe.AddRecipe();
			}
		}
		public class DecorativeBouncyGlowstick : ModItem
		{
			public override void SetDefaults()
			{
				item.width = 12;
				item.height = 12;
				item.maxStack = 999;
				item.useTurn = true;
				item.autoReuse = true;
				item.useAnimation = 15;
				item.useTime = 7;
				item.useStyle = 1;
				item.consumable = true;
				item.createTile = mod.TileType("BouncyGlowstick");
			}

			public override void AddRecipes()
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.BouncyGlowstick, 1);
				recipe.AddTile(null,"SculptingStand");
				recipe.SetResult(this, 1);
				recipe.AddRecipe();
			}
		}
		public class DecorativeStickyGlowstick : ModItem
		{
			public override void SetDefaults()
			{
				item.width = 12;
				item.height = 12;
				item.maxStack = 999;
				item.useTurn = true;
				item.autoReuse = true;
				item.useAnimation = 15;
				item.useTime = 7;
				item.useStyle = 1;
				item.consumable = true;
				item.createTile = mod.TileType("StickyGlowstick");
			}

			public override void AddRecipes()
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.StickyGlowstick, 1);
				recipe.AddTile(null,"SculptingStand");
				recipe.SetResult(this, 1);
				recipe.AddRecipe();
			}
		}
		public class DecorativeSpelunkerGlowstick : ModItem
		{
			public override void SetDefaults()
			{
				item.width = 12;
				item.height = 12;
				item.maxStack = 999;
				item.useTurn = true;
				item.autoReuse = true;
				item.useAnimation = 15;
				item.useTime = 7;
				item.useStyle = 1;
				item.consumable = true;
				item.createTile = mod.TileType("SpelunkerGlowstick");
			}

			public override void AddRecipes()
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.SpelunkerGlowstick, 1);
				recipe.AddTile(null,"SculptingStand");
				recipe.SetResult(this, 1);
				recipe.AddRecipe();
			}
		}
	}
}}