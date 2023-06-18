// From old branch



// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.SceneManagement;
// using UnityEditor;
// using UnityEditor.Build;

// namespace KRT.VRCQuestTools
// {

//     public class SwitchPlatformSupporter : MonoBehaviour
//     {
//         public GameObject[] AndroidObjects = new GameObject[] { };
//         public GameObject[] PCObjects = new GameObject[] { };

//         internal void UpdateObjects()
//         {
//             var currentBuildTarget = EditorUserBuildSettings.activeBuildTarget;
//             Debug.Log($"[{this.GetType().Name}] Update game objects for {currentBuildTarget}");
//             foreach (var go in AndroidObjects)
//             {
//                 var active = currentBuildTarget == BuildTarget.Android;
//                 var action = active ? "Activate" : "Deactivate";
//                 Debug.Log($"[{this.GetType().Name}] {action} {go}");
//                 go.SetActive(active);
//             }
//             foreach (var go in PCObjects)
//             {
//                 var active = currentBuildTarget == BuildTarget.StandaloneWindows64;
//                 var action = active ? "Activate" : "Deactivate";
//                 Debug.Log($"[{this.GetType().Name}] {action} {go}");
//                 go.SetActive(active);
//             }
//         }
//     }

//     public class SwitchPlatformSupporterMenu : IActiveBuildTargetChanged
//     {
//         public int callbackOrder => 0;

//         [MenuItem("VRCQuestTools/Update Scene Objects for Current Platform")]
//         static void UpdateSceneObjects()
//         {
//             var scene = SceneManager.GetActiveScene();
//             var rootGameObjects = scene.GetRootGameObjects();
//             foreach (var obj in rootGameObjects)
//             {
//                 var supporters = obj.GetComponentsInChildren<SwitchPlatformSupporter>();
//                 foreach (var s in supporters)
//                 {
//                     s.UpdateObjects();
//                 }
//             }
//         }

//         public void OnActiveBuildTargetChanged(BuildTarget previousTarget, BuildTarget newTarget)
//         {
//             EditorApplication.delayCall += UpdateSceneObjects;
//         }
//     }
// }
