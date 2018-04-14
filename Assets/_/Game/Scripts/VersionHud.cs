namespace DH.BuildVersion.Game
{
    using System;
    using System.Collections;
    
    using UnityEngine;
    
    public class VersionHud : MonoBehaviour
    {
        public UnityEngine.UI.Text versionLabel;
        
//        public string filePath = System.IO.Path.Combine(Application.streamingAssetsPath, "build.txt");

        void Start()
        {
            StartCoroutine(ReadBuildFile());
        }
        
        IEnumerator ReadBuildFile()
        {
            string filePath = System.IO.Path.Combine(Application.streamingAssetsPath, "build.txt");
            var result = System.IO.File.ReadAllText(filePath);
            versionLabel.text = result;
            yield return null;
        }

        public void SetVersion(string major, string minor, string patch)
        {
            var desc = string.Format("Ver. {0}.{1}.{2}", major, minor, patch);
            versionLabel.text = desc;
        }
    }
}