using MelonLoader;
using BTD_Mod_Helper;
using FirstBloonsMod;
using Il2CppAssets.Scripts.Simulation.Towers;
using Il2CppAssets.Scripts.Simulation.Objects;
using Il2CppAssets.Scripts.Models;

[assembly: MelonInfo(typeof(FirstBloonsMod.FirstBloonsMod), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace FirstBloonsMod;

public class FirstBloonsMod : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<FirstBloonsMod>("FirstBloonsMod loaded!");
    }
    public override void OnTowerCreated(Tower tower, Entity target, Model modelToUse)
    {
        if (tower.towerModel.name.Contains("EngineerMonkey"))
        {
            ModHelper.Msg<FirstBloonsMod>("EngineerMonkey created!");
        }
        else if (tower.towerModel.name.Contains("TechBot"))
        {
            ModHelper.Msg<FirstBloonsMod>("TechBot created!");
        }
        base.OnTowerCreated(tower, target, modelToUse);
    }

}