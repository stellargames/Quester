using System.Collections.Generic;

namespace Quester
{
    internal static class ItemMapper
    {
        public static readonly Dictionary<ItemCategory, List<string>> ItemMap = new Dictionary<ItemCategory, List<string>>
        {
            [ItemCategory.Drugs] = new List<string>
            {
                "Indulcet",
                "Sursum",
                "Quaesto_Vil",
                "Aegrotat"
            },
            [ItemCategory.Container] = new List<string>
            {
                "Glass_Jar",
                "Glass_Bottle",
                "Decanter",
                "Clay_Jar",
                "Small_Sack",
                "Large_Sack",
                "Quiver",
                "Backpack",
                "Small_Chest",
                "Wine_Rack",
                "Large_Chest",
                "Dummy11",
                "Dummy12",
                "Dummy13",
                "Dummy14",
                "Dummy15",
                "Large_Chest"
            },
            [ItemCategory.Armor] = new List<string>
            {
                "Cuirass",
                "Gauntlets",
                "Greaves",
                "Left_Pauldron",
                "Right_Pauldron",
                "Helm",
                "Boots",
                "Buckler",
                "Round_Shield",
                "Kite_Shield",
                "Tower_Shield"
            },
            [ItemCategory.Weapon] = new List<string>
            {
                "Dagger",
                "Tanto",
                "Staff",
                "Shortsword",
                "Wakazashi",
                "Broadsword",
                "Saber",
                "Longsword",
                "Katana",
                "Claymore",
                "Dai_Katana",
                "Mace",
                "Flail",
                "Warhammer",
                "Battle_Axe",
                "War_Axe",
                "Short_Bow",
                "Long_Bow",
                "Arrow"
            },
            [ItemCategory.Artifact] = new List<string>
            {
                "Masque_of_Clavicus",
                "Mehrunes_Razor",
                "Mace_of_Molag_Bal",
                "Hircine_Ring",
                "Sanguine_Rose",
                "Oghma_Infinium",
                "Wabbajack",
                "Ring_of_Namira",
                "Skull_of_Corruption",
                "Azuras_Star",
                "Volendrung",
                "Warlocks_Ring",
                "Auriels_Bow",
                "Necromancers_Amulet",
                "Chrysamere",
                "Lords_Mail",
                "Staff_of_Magnus",
                "Ring_of_Khajiit",
                "Ebony_Mail",
                "Auriels_Shield",
                "Spell_Breaker",
                "Skeletons_Key",
                "Ebony_Blade"
            },
            [ItemCategory.MensClothing] = new List<string>
            {
                "Straps",
                "Armbands",
                "Kimono",
                "Fancy_Armbands",
                "Sash",
                "Eodoric",
                "Shoes",
                "Tall_Boots",
                "Boots",
                "Sandals",
                "Casual_pants",
                "Breeches",
                "Short_skirt",
                "Casual_cloak",
                "Formal_cloak",
                "Khajiit_suit",
                "Dwynnen_surcoat",
                "Short_tunic",
                "Formal_tunic",
                "Toga",
                "Reversible_tunic",
                "Loincloth",
                "Plain_robes",
                "Priest_robes",
                "Short_shirt",
                "Short_shirt_with_belt",
                "Long_shirt",
                "Long_shirt_with_belt",
                "Short_shirt_closed_top",
                "Short_shirt_closed_top2",
                "Long_shirt_closed_top",
                "Long_shirt_closed_top2",
                "Open_Tunic",
                "Wrap",
                "Long_Skirt",
                "Anticlere_Surcoat",
                "Challenger_Straps",
                "Short_shirt_unchangeable",
                "Long_shirt_unchangeable",
                "Vest",
                "Champion_straps"
            },
            [ItemCategory.Book] = new List<string>
            {
                "Book0",
                "Book1",
                "Book2",
                "Book3"
            },
            [ItemCategory.Furniture] = new List<string>
            {
                "Plain_single_bed",
                "Fancy_single_bed",
                "Plain_double_bed",
                "Fancy_double_bed",
                "Large_oak_table",
                "Large_cherry_table",
                "Large_mahogany_table",
                "Large_teak_table",
                "Small_oak_table",
                "Small_cherry_table",
                "Small_mahogany_table",
                "Small_teak_table",
                "Oak_chair",
                "Cherry_chair",
                "Mahogany_chair",
                "Teak_chair",
                "Curtains",
                "Fancy_curtains",
                "Large_pillow",
                "Small_pillow",
                "Small_plain_rug",
                "Large_plain_rug",
                "Small_fine_rug",
                "Large_fine_rug",
                "Large_tapestry",
                "Medium_tapestry",
                "Small_tapestry",
                "Large_skins",
                "Small_skins"
            },
            [ItemCategory.Usable] = new List<string>
            {
                "Torch",
                "Lantern",
                "Bandage",
                "Oil",
                "Candle",
                "Parchment"
            },
            [ItemCategory.ReligiousItem] = new List<string>
            {
                "Prayer_beads",
                "Rare_symbol",
                "Common_symbol",
                "Bell",
                "Holy_water",
                "Talisman",
                "Religious_item",
                "Small_statue",
                "Icon",
                "Scarab",
                "Holy_candle",
                "Holy_dagger",
                "Holy_tome"
            },
            [ItemCategory.Map] = new List<string>
            {
                "Map"
            },
            [ItemCategory.WomensClothing] = new List<string>
            {
                "Brassier",
                "Formal_brassier",
                "Peasant_blouse",
                "Eodoric",
                "Shoes",
                "Tall_boots",
                "Boots",
                "Sandals",
                "Casual_pants",
                "Casual_cloak",
                "Formal_cloak",
                "Khajiit_suit",
                "Formal_eodoric",
                "Evening_gown",
                "Day_gown",
                "Casual_dress",
                "Strapless_dress",
                "Loincloth",
                "Plain_robes",
                "Priestess_robes",
                "Short_shirt",
                "Short_shirt_belt",
                "Long_shirt",
                "Long_shirt_belt",
                "Short_shirt_closed",
                "Short_shirt_closed_belt",
                "Long_shirt_closed",
                "Long_shirt_closed_belt",
                "Open_tunic",
                "Wrap",
                "Long_skirt",
                "Tights",
                "Short_shirt_unchangeable",
                "Long_shirt_unchangeable",
                "Vest"
            },
            [ItemCategory.Painting] = new List<string>
            {
                "Painting1",
                "Painting2",
                "Painting3",
                "Portrait"
            },
            [ItemCategory.Gem] = new List<string>
            {
                "Ruby",
                "Emerald",
                "Sapphire",
                "Diamond",
                "Jade",
                "Turquoise",
                "Malachite",
                "Amber"
            },
            [ItemCategory.SmallPlant] = new List<string>
            {
                "Twigs",
                "Green_leaves",
                "Red_flowers",
                "Yellow_flowers",
                "Root_tendrils",
                "Root_bulb",
                "Pine_branch",
                "Green_berries",
                "Red_berries",
                "Yellow_berries",
                "Clover",
                "Red_rose",
                "Yellow_rose",
                "Red_poppy",
                "Golden_poppy"
            },
            [ItemCategory.LargePlant] = new List<string>
            {
                "Twigs",
                "Green_leave",
                "Red_flowers",
                "Yellow_flowers",
                "Root_tendrils",
                "Root_bulb",
                "Green_berries",
                "Red_berries",
                "Yellow_berries",
                "Black_rose",
                "White_rose",
                "Black_poppy",
                "White_poppy",
                "Ginkgo_leaves",
                "Bamboo",
                "Palm",
                "Aloe",
                "Fig",
                "Cactus"
            },
            [ItemCategory.Jewellery] = new List<string>
            {
                "Amulet",
                "Bracer",
                "Ring",
                "Bracelet",
                "Mark",
                "Torc",
                "Cloth_amulet",
                "Wand"
            },
            [ItemCategory.MiscellaneousIngredients1] = new List<string>
            {
                "Holy_relic",
                "Big_tooth",
                "Medium_tooth",
                "Small_tooth",
                "Pure_water",
                "Rain_water",
                "Elixir_vitae",
                "Nectar",
                "Ichor"
            },
            [ItemCategory.QuestItem] = new List<string>
            {
                "Telescope",
                "Scales",
                "Globe",
                "Skeleton",
                "Totem",
                "Dead_body",
                "Mantella",
                "Finger"
            },
            [ItemCategory.MiscItem] = new List<string>
            {
                "Spellbook",
                "Soul_trap",
                "Letter_of_credit",
                "Unused",
                "Potion_recipe",
                "Dead_Body",
                "House_Deed",
                "Ship_Deed",
                "Map"
            },
            [ItemCategory.Transportation] = new List<string>
            {
                "Small_cart",
                "Horse",
                "Rowboat",
                "Large_boat",
                "Small_ship",
                "Large_Galley"
            },
            [ItemCategory.CreatureIngredients1] = new List<string>
            {
                "Werewolfs_blood",
                "Fairy_dragon_scales",
                "Wraith_essence",
                "Ectoplasm",
                "Ghouls_tongue",
                "Spider_venom",
                "Troll_blood",
                "Snake_venom",
                "Gorgon_snake",
                "Lich_dust",
                "Giant_blood",
                "Basilisk_eye",
                "Daedra_heart",
                "Saints_hair",
                "Orcs_blood"
            },
            [ItemCategory.CreatureIngredients2] = new List<string>
            {
                "Dragons_scales",
                "Giant_scorpion_stinger",
                "Small_scorpion_stinger",
                "Mummy_wrappings",
                "Gryphon_Feather"
            },
            [ItemCategory.CreatureIngredients3] = new List<string>
            {
                "Wereboar_tusk",
                "Nymph_hair",
                "Unicorn_horn"
            },
            [ItemCategory.MiscellaneousIngredients2] = new List<string>
            {
                "Ivory",
                "Pearl"
            },
            [ItemCategory.MagicItem] = new List<string>
            {
                "Silent %it",
                "%it of the Wise",
                "%it of Wildfire",
                "%it of Force Bolts",
                "Shining %it",
                "%it of the Sealed Door",
                "%it of Undeniable Access",
                "%it of Venom Antidote",
                "%it of Life Stealing",
                "%it of Wizard's Fire",
                "Leaping %it",
                "%it of Water-walking",
                "%it of Magicka",
                "Never Tiring %it",
                "%it of Featherweight",
                "%it, the Protector",
                "%it of Shocking",
                "Cursing %it",
                "%it of Far Silence",
                "%it of Venom Spitting",
                "Blazing %it of Fireballs",
                "Frosty %it of Ice Storms",
                "%it of Lightning",
                "Deadman's %it",
                "Healing %it",
                "%it of the Orc Lord",
                "Unrestrainable %it",
                "%it of Iron Will",
                "%it of Nimbleness",
                "Torgo's %it",
                "%it of Fortitude",
                "%it of Friendship",
                "%it of Good Luck",
                "%it of Oblivion",
                "%it of Toxic Clouds",
                "%it of Paralysis",
            },
            [ItemCategory.MetalIngredients] = new List<string>
            {
                "Mercury",
                "Tin",
                "Brass",
                "Lodestone",
                "Sulphur",
                "Lead",
                "Iron",
                "Copper",
                "Silver",
                "Gold",
                "Platinum"
            }
        };
    }
}