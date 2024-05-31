using UnityEngine;
using UnityEditor;
using System.IO;

public class BuildScript : MonoBehaviour
{
    [MenuItem("Build/Build Project")]
    public static void BuildProject()
    {
        // Define the build path
        string buildPath = "Builds/MyGame.exe";

        // Define the scenes to be included in the build
        string[] scenes = new string[]
        {
            "Assets/Scenes/main.unity"
        };

        // Set build options
        BuildOptions buildOptions = BuildOptions.None;

        // Build the project
        BuildPipeline.BuildPlayer(scenes, buildPath, BuildTarget.StandaloneWindows64, buildOptions);

        // Log a message when the build is complete
        Debug.Log("Build Complete!");
    }
}
