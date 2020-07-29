using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
    
public class APKBuild : Editor
{
      [MenuItem("Tools/BuildApk")]
      public static void build()
      {
            BuildTarget buildTarget = BuildTarget.Android;
            EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android,buildTarget);
            PlayerSettings.companyName = "yunkun";
            PlayerSettings.productName = "Demo";
            List<string> levels = new  List<string>();
            foreach (var values in EditorBuildSettings.scenes)
            {
                  if (!values.enabled)
                  {
                        continue;
                  }
                  levels.Add(values.path);
            }

            string apkName = string.Format("./{0}.apk", "Demo");
            BuildPipeline.BuildPlayer(levels.ToArray(), apkName, buildTarget, BuildOptions.None);
            AssetDatabase.Refresh();
      }
      
    
}
