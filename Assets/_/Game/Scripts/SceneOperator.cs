namespace DH.BuildVersion.Game
{
    public class SceneOperator : Zenject.IInitializable
    {
        private readonly AppwideSOI.Settings _appwideSoiSEttings;
        private readonly ScenewideInstaller.Settings _scenewideSettings;
        
        public SceneOperator(
            AppwideSOI.Settings appwideSoiSEttings,
            ScenewideInstaller.Settings scenewideSettings)
        {
            _appwideSoiSEttings = appwideSoiSEttings;
            _scenewideSettings = scenewideSettings;
        }

        public void Initialize()
        {
//            _scenewideSettings.
//            _scenewideSettings.versionHud.SetVersion(_appwideSoiSEttings.major, _appwideSoiSEttings.minor, _appwideSoiSEttings.patch);
        }
    }
}