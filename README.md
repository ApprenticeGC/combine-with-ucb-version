# Demo Overview

Show how to combine the build version settings from Zenject with Unity Cloud Build(UCB) buildNumber and form a file that stores in StreamingAssets. This file stores build version in

- Major
- Minor
- Patch
- Build

order separted by "." as the content. And this file is read during runtime to be presented as build info.

Since this is a demo, only store relevant files and folders. And most configuration doesn't set properly.

The plugins used is

- Zenject

and Unity service(s)

- Unity Collaborate
- Unity Cloud Build

are used.

The key point is the script that deals string truncation from Zenject scriptable object installer with buildNumber pass in as build manifest.

```
public class HandleBuildVersion
{
    #if UNITY_CLOUD_BUILD
    public static void TestPostPreExport(UnityEngine.CloudBuild.BuildManifestObject manifest)
    {
        var appwideSOI = Resources.Load<Game.AppwideSOI>("AppwideSOI");
        var buildNumber = manifest.GetValue("buildNumber", "unknown");

        var filePath = Path.Combine(Application.streamingAssetsPath, "build.txt");

        var buildDesc = string.Format(
            "{0}.{1}.{2}.{3}",
            appwideSOI.settings.major,
            appwideSOI.settings.minor,
            appwideSOI.settings.patch,
            buildNumber);
        
        using (var outfile = new StreamWriter(filePath))
        {
            outfile.Write(buildDesc);
        }            
    }
    #endif
}
```
