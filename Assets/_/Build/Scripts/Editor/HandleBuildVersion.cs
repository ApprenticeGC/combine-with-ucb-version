//#if UNITY_CLOUD_BUILD
//using System;
//using UnityEngine;
//using UnityEditor;
//using System.Collections;
//using System.Collections.Generic;
// 
//public class PostPreExportEditor : MonoBehaviour {
// 
//  public static void TestPostPreExport(UnityEngine.CloudBuild.BuildManifestObject manifest)
//  {
//     string buildNum = manifest.GetValue('buildNumber', 'unknown');
//     Debug.LogWarning('PREBUILD Script launched, build number is ' + buildNum);
//  }
// 
//}
//#endif

namespace DH.BuildVersion.Build
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;    
    
    using UnityEngine;
    using UnityEditor;

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
}