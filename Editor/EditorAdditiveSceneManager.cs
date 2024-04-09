using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using UnityWorkflowTools;

namespace UnityWorkflowTools.Editor
{
    [InitializeOnLoad]
    public class EditorAdditiveSceneManager 
    { 
        [InitializeOnLoadMethod]
        private static void Initialize()
        {
            EditorSceneManager.sceneOpened += OnEditorSceneOpened;
        }

        private static void OnEditorSceneOpened(Scene scene, OpenSceneMode mode)
        {
            if (scene != SceneManager.GetActiveScene()) { return; }
            AdditiveSceneManager sceneManager = UnityEngine.Object.FindAnyObjectByType<AdditiveSceneManager>();
            sceneManager?.LoadSceneList();
        }
    }
}

