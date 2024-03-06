using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Builder : MonoBehaviour
{
    [MenuItem("Custom/Build Windows Standalone")]
    public static void BuildWindowsStandalone()
    {
        // Specify the output path for the build
        string outputPath = "Builds/Windows/";

        // Create the directory if it doesn't exist
        if (!System.IO.Directory.Exists(outputPath))
        {
            System.IO.Directory.CreateDirectory(outputPath);
        }

        // Build options
        BuildOptions buildOptions = BuildOptions.None;

        // Build the Windows standalone executable
        BuildPipeline.BuildPlayer(GetScenes(), outputPath + "MyGame.exe", BuildTarget.StandaloneWindows, buildOptions);
    }

    // Helper method to get all enabled scenes for the build
    private static string[] GetScenes()
    {
        string[] scenePaths = new string[EditorBuildSettings.scenes.Length];
        for (int i = 0; i < EditorBuildSettings.scenes.Length; i++)
        {
            scenePaths[i] = EditorBuildSettings.scenes[i].path;
        }
        return scenePaths;
    }
}
