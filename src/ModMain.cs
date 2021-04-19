using Vintagestory.API.Common;

namespace ApicultureMod
{
  public class ModMain : ModSystem
  {
    public override void Start(ICoreAPI api)
    {
      base.Start(api);
      api.RegisterBlockClass(FramedHiveBlock._name, typeof(FramedHiveBlock));
    }
  }
}