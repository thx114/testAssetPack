using Colossal.Logging;
using Game;
using Game.Modding;
using Game.SceneFlow;

// 这里不需要修改
namespace CustomAssetPack
{
    public class Mod : IMod
    {
        public static ILog log = LogManager.GetLogger($"{nameof(CustomAssetPack)}.{nameof(Mod)}")
            .SetShowsErrorsInUI(false);

        public void OnLoad(UpdateSystem updateSystem)
        {
            log.Info("Loading Asset Pack " + nameof(CustomAssetPack));
        }

        public void OnDispose()
        {
        }
    }
}