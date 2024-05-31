using UnityEngine;
using UnityEditor;
using System.IO;

public class BuildScript : MonoBehaviour
{
    [MenuItem("Build/Build Project")]
    public static void BuildProject()
    {
        // Define the relative build path
        string buildPath = "Builds/MyGame.exe";

        // Ensure the directory exists
        string directory = Path.GetDirectoryName(buildPath);
        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }

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
