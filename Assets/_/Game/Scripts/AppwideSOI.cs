namespace DH.BuildVersion.Game
{
    using UnityEngine;
    
    [CreateAssetMenu(fileName = "AppwideSOI", menuName = "Installers/App/AppwideSOI")]
    public class AppwideSOI :  Zenject.ScriptableObjectInstaller<AppwideSOI>
    {
        [System.Serializable]
        public class Settings
        {
            public string major;
            public string minor;
            public string patch;
        }
        
        public Settings settings;

        public override void InstallBindings()
        {
            Container.Bind<Settings>().FromInstance(settings).AsSingle();            
        }
    }
}