namespace DH.BuildVersion.Game
{
    public class ScenewideInstaller : Zenject.MonoInstaller
    {
        [System.Serializable]
        public class Settings
        {
            public VersionHud versionHud;
        }
        
        public Settings settings;        

        public override void InstallBindings()
        {
            Container.Bind<Settings>().FromInstance(settings).AsSingle();    
            Container.BindInterfacesAndSelfTo<SceneOperator>().AsSingle();
        }
    }
}