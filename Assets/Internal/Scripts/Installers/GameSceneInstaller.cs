using Zenject;

namespace ReactionGames.Installers
{
    public sealed class GameSceneInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInstance(_enemySpawnPoint);  
            Container.BindInstance(_enemyPatrolPoints);
        }
    }
}
