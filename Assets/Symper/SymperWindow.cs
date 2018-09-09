using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using System;
using System.Collections.Generic;


public class SymperWindow : EditorWindow {

    static int i = 0;

    static int[] j = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    
    [MenuItem("Symper/Run")]
	public static void ShowWindow()
	{
        GetWindow<SymperWindow>("Symper");
	}

    Vector2 scrollPos;

    void OnExportClick()
    {
        List<string> assetPath = new List<string>();

        Debug.Log(assetPath.ToString());

        #region WaypointSelects
        if (j[0] == 1)
        {
            assetPath.Add("Assets/Symper/Prefabs/BasicPatrolController.prefab");
            assetPath.Add("Assets/Symper/Scripts/BasicWaypoint.cs");
        }
        if (j[1] == 1)
        {
            assetPath.Add("Assets/Symper/Prefabs/DynamicPatrolController.prefab");
            assetPath.Add("Assets/Symper/Scripts/BasicWaypoint.cs"); // DynamicWaypoint derives from BasicWaypoint
            assetPath.Add("Assets/Symper/Prefabs/DynamicWaypoint.cs");
        }
        if (j[2] == 1)
        {
            assetPath.Add("Assets/Symper/Prefabs/WPCircuit.prefab");
            assetPath.Add("Assets/Symper/Scripts/WaypointCircuit.cs");
        }
        if (j[3] == 1)
        {
            assetPath.Add("Assets/Symper/Scripts/WaypointCircuit.cs");
            assetPath.Add("Assets/Symper/Scripts/FollowGoal.cs");
            assetPath.Add("Assets/Symper/Scripts/WaypointProgressTracker.cs");
            assetPath.Add("Assets/Symper/Scripts/FollowForward.cs");
        }
        if (j[4] == 1)
        {
            assetPath.Add("Assets/Symper/Prefabs/WPManager.prefab");
            assetPath.Add("Assets/Symper/Scripts/WPManager.cs");
            assetPath.Add("Assets/Symper/Scripts/FollowPath.cs");
            assetPath.Add("Assets/Symper/Scripts/Graphs/Edge.cs");
            assetPath.Add("Assets/Symper/Scripts/Graphs/Graph.cs");
            assetPath.Add("Assets/Symper/Scripts/Graphs/Node.cs");
        }
        if (j[5] == 1)
        {
            assetPath.Add("Assets/Symper/Prefabs/WPCircuit.prefab");
            assetPath.Add("Assets/Symper/Scripts/WaypointCircuit.cs");
            assetPath.Add("Assets/Symper/Scripts/CarController.cs");
            assetPath.Add("Assets/Symper/Scripts/CarAIControl.cs");
            assetPath.Add("Assets/Symper/Scripts/WaypointProgressTracker.cs");
           // assetPath.Add("Assets/Symper/Scripts/CarAudio.cs");
        }
        #endregion

        #region NavMeshSelects
        if (j[6] == 1)
        {
            assetPath.Add("Assets/Symper/DemoAssets/NavMeshComponents/Scripts/NavMeshSurface.cs");
        }
        if (j[7] == 1)
        {
            assetPath.Add("Assets/Symper/Prefabs/NavMeshBasicController.prefab");
            assetPath.Add("Assets/Symper/Scripts/NPCMove.cs");
        }
        if (j[8] == 1)
        {
            assetPath.Add("Assets/Symper/Prefabs/WPManager.prefab");
            assetPath.Add("Assets/Symper/Scripts/WPManager.cs");
            assetPath.Add("Assets/Symper/Scripts/FollowPath.cs");
            assetPath.Add("Assets/Symper/Scripts/Graphs/Edge.cs");
            assetPath.Add("Assets/Symper/Scripts/Graphs/Graph.cs");
            assetPath.Add("Assets/Symper/Scripts/Graphs/Node.cs");
        }
        if (j[9] == 1)
        {
            assetPath.Add("Assets/Symper/Prefabs/AgentManager.prefab");
            assetPath.Add("Assets/Symper/Scripts/AgentManager.cs");
            assetPath.Add("Assets/Symper/Scripts/AIControl.cs");
        }
        if (j[10] == 1)
        {
            assetPath.Add("Assets/Symper/Prefabs/AgentManagerRes.prefab");
            assetPath.Add("Assets/Symper/Scripts/AgentManagerRes.cs");
            assetPath.Add("Assets/Symper/Scripts/AIControl.cs");
        }
        if (j[11] == 1)
        {
            assetPath.Add("Assets/Symper/Scripts/ChasePlayer.cs");
            assetPath.Add("Assets/Symper/Scripts/LocotionSimpleAgent.cs");
        }
        if (j[12] == 1)
        {
            assetPath.Add("Assets/Symper/Scripts/ChasePlayer.cs");
            assetPath.Add("Assets/Symper/Scripts/LocotionSimpleAgent.cs");
            assetPath.Add("Assets/Symper/Scripts/LookAt.cs");
            assetPath.Add("Assets/Symper/Scripts/ClickToMove.cs");
        }
        #endregion

        #region BasicTracking
        if (j[13] == 1)
        {
            assetPath.Add("Assets/Symper/Scripts/Move.cs");
            assetPath.Add("Assets/Symper/Scripts/MoveToGoal.cs");
        }
        if (j[14] == 1)
        {
            assetPath.Add("Assets/Symper/Scripts/Move.cs");
            assetPath.Add("Assets/Symper/Scripts/MoveLocal.cs");
        }
        if (j[15] == 1)
        {
            assetPath.Add("Assets/Symper/Scripts/Move.cs");
            assetPath.Add("Assets/Symper/Scripts/PetMover.cs");
        }
        #endregion

        #region GroupSelects
        if (j[16] == 1)
        {
            assetPath.Add("Assets/Symper/Scripts/AIControl.cs");
            assetPath.Add("Assets/Symper/Scripts/CrowdBehaviorController.cs");
            assetPath.Add("Assets/Symper/Prefabs/CrowdBehaviorController.prefab");
        }
        if (j[17] == 1)
        {
            assetPath.Add("Assets/Symper/Scripts/AIControlAgent.cs");
        }
        if (j[18] == 1)
        {
            assetPath.Add("Assets/Symper/Scripts/AIControlAgent.cs");
        }
        if (j[19] == 1)
        {
            assetPath.Add("Assets/Symper/Prefabs/FlockManager.cs");
            assetPath.Add("Assets/Symper/Scripts/FlockManager.cs");
        }
        if (j[20] == 1)
        {
            assetPath.Add("Assets/Symper/Prefabs/FlockManager.cs");
            assetPath.Add("Assets/Symper/Scripts/FlockManager.cs");
        }
        #endregion

        #region FSMSelect
        if (j[21] == 1)
        {
            assetPath.Add("Assets/Symper/DemoAssets/LastLegs/FSM/NPCFSM.anim");
            assetPath.Add("Assets/Symper/Scripts/Patrol.cs");
            assetPath.Add("Assets/Symper/Scripts/Chase.cs");
            assetPath.Add("Assets/Symper/Scripts/Attack.cs");
        }
        #endregion

        #region BTSelect
        if (j[22] == 1)
        {
            assetPath.Add("Assets/Symper/DemoAssets/LastLegs/BT/PandaBehavior/Core/PandaBehavior.cs");
            assetPath.Add("Assets/Symper/DemoAssets/LastLegs/BT/PandaBehavior/Core/PandaBehavior.dll");
            assetPath.Add("Assets/Symper/DemoAssets/LastLegs/BT/PandaBehavior/Core/Editor/Gizmos/PandaScript.png");
            assetPath.Add("Assets/Symper/DemoAssets/LastLegs/BT/PandaBehavior/Core/Editor/CreatePandaScriptMenu.cs");
            assetPath.Add("Assets/Symper/DemoAssets/LastLegs/BT/PandaBehavior/Core/Editor/PandaBehaviorEditor.cs");
            assetPath.Add("Assets/Symper/DemoAssets/LastLegs/BT/PandaBehavior/Core/Editor/PandaBehaviorEditor.dll");
            assetPath.Add("Assets/Symper/DemoAssets/LastLegs/BT/AI.cs");
            assetPath.Add("Assets/Symper/DemoAssets/LastLegs/BT/DriveBT.cs");
            assetPath.Add("Assets/Symper/DemoAssets/LastLegs/BT/Attack.BT.txt");
            assetPath.Add("Assets/Symper/DemoAssets/LastLegs/BT/BotAI.BT.txt");
            assetPath.Add("Assets/Symper/DemoAssets/LastLegs/BT/Flee.BT.txt");
            assetPath.Add("Assets/Symper/DemoAssets/LastLegs/BT/LookAround.BT.txt");
            assetPath.Add("Assets/Symper/DemoAssets/LastLegs/BT/Patrol.BT.txt");
            assetPath.Add("Assets/Symper/DemoAssets/LastLegs/BT/Wander.BT.txt");
        }
        #endregion

        #region GOAPSelect
        if (j[23] == 1)
        {
            assetPath.Add("Assets/Symper/Scripts/AI/GOAP/GoapAction.cs");
            assetPath.Add("Assets/Symper/Scripts/AI/GOAP/GoapAgent.cs");
            assetPath.Add("Assets/Symper/Scripts/AI/GOAP/GoapPlanner.cs");
            assetPath.Add("Assets/Symper/Scripts/AI/GOAP/IGoap.cs");
            assetPath.Add("Assets/Symper/Scripts/Inventory.cs");
        }
        #endregion

        else
        {
            assetPath.Add("Assets/Symper/Prefabs/EmptyPrefab.prefab");
        }

        AssetDatabase.ExportPackage(assetPath.ToArray(), EditorUtility.SaveFilePanel("Save Symper Export Package", "", "SymperBehaviors.unitypackage", "unitypackage"), ExportPackageOptions.IncludeDependencies);

    }
    
    void OnGUI ()
    {
        #region WelcomePage
        if (i == 0)
        {
            GUILayout.Label("Welcome to Symper", EditorStyles.boldLabel);

            if (GUILayout.Button("Behavior Menu"))
            {
                i = 1;
                Repaint();
            }

            GUILayout.Space(5.0f);
        
            if (GUILayout.Button("Guide"))
            {
                Help.BrowseURL("https://atinagnihotri.com/blog/guide-to-symper/");
            }
            GUILayout.Space(5.0f);

            if (GUILayout.Button("Export Selected Behaviors"))
            {
                OnExportClick();
            }
        }
        #endregion

        #region BehaviorTypesPage
        else if (i == 1)
        {
            GUILayout.Label("Behavior Types", EditorStyles.boldLabel);
            if (GUILayout.Button("Singletons"))
            {
                i = 2;
                Repaint();
            }
            GUILayout.Space(5.0f);
            if (GUILayout.Button("Bundled"))
            {
                i = 3;
                Repaint();
            }
            GUILayout.Space(5.0f);

            if (GUILayout.Button("Export Selected Behaviors"))
            {
                OnExportClick();
            }
            GUILayout.Space(5.0f);
            if (GUILayout.Button("Back"))
            {
                i = 0;
                Repaint();
            }


        }
        #endregion

        #region SingletonsPage
        else if (i == 2)
        {
            GUILayout.Label("Singletons", EditorStyles.boldLabel);
            if (GUILayout.Button("Waypoints Based"))
            {
                i = 4;
                Repaint();
            }
            GUILayout.Space(5.0f);
            if (GUILayout.Button("NavMesh Based"))
            {
                i = 5;
                Repaint();
            }
            GUILayout.Space(5.0f);
            if (GUILayout.Button("Basic Tracking"))
            {
                i = 6;
                Repaint();
            }
            GUILayout.Space(5.0f);
            if (GUILayout.Button("Back"))
            {
                i = 1;
                Repaint();
            }
            

        }
        #endregion

        #region BundledPage
        else if (i == 3)
        {
            GUILayout.Label("Bundled Behaviors", EditorStyles.boldLabel);
            if (GUILayout.Button("Group Behavior"))
            {
                i = 7;
                Repaint();
            }
            GUILayout.Space(5.0f);
            if (GUILayout.Button("Finite State Machines"))
            {
                i = 8;
                Repaint();
            }
            GUILayout.Space(5.0f);
            if (GUILayout.Button("Behavior Trees"))
            {
                i = 9;
                Repaint();
            }
            GUILayout.Space(5.0f);
            if (GUILayout.Button("Goal Oriented Action Planning"))
            {
                i = 10;
                Repaint();
            }
            GUILayout.Space(5.0f);
            if (GUILayout.Button("Back"))
            {
                i = 1;
                Repaint();
            }

        }
        #endregion

        #region WaypointPage
        else if (i == 4)
        {
            GUILayout.Label("Waypoint based", EditorStyles.boldLabel);

            if (j[0] == 0)
            {
                GUILayout.Label("Basic Patrol");

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/basicPatrol.unity");
                }

                else if (GUILayout.Button("Select"))
                {
                    j[0] = 1;
                    Repaint();
                }
            }
            else if (j[0] == 1)
            {
                GUILayout.Label("Basic Patrol [SELECTED]", EditorStyles.boldLabel);

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/basicPatrol.unity");
                }

                else if (GUILayout.Button("Deselect"))
                {
                    j[0] = 0;
                    Repaint();
                }
            }

            if (j[1] == 0)
            {
                GUILayout.Label("Dynamic Patrol");

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/dynamicPatrol.unity");
                }

                else if (GUILayout.Button("Select"))
                {
                    j[1] = 1;
                    Repaint();
                }
            }
            else if (j[1] == 1)
            {
                GUILayout.Label("Dynamic Patrol [SELECTED]", EditorStyles.boldLabel);

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/dynamicPatrol.unity");
                }

                else if (GUILayout.Button("Deselect"))
                {
                    j[1] = 0;
                    Repaint();
                }
            }

            if (j[2] == 0)
            {
                GUILayout.Label("Tracked");

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/RaceTrack.unity");
                }

                else if (GUILayout.Button("Select"))
                {
                    j[2] = 1;
                    Repaint();
                }
            }
            else if (j[2] == 1)
            {
                GUILayout.Label("Tracked [SELECTED]", EditorStyles.boldLabel);

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/RaceTrack.unity");
                }

                else if (GUILayout.Button("Deselect"))
                {
                    j[2] = 0;
                    Repaint();
                }
            }

            if (j[3] == 0)
            {
                GUILayout.Label("Waypoint Selection");

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/Waypoints.unity");
                }

                else if (GUILayout.Button("Select"))
                {
                    j[3] = 1;
                    Repaint();
                }
            }
            else if (j[3] == 1)
            {
                GUILayout.Label("Waypoint Selection [SELECTED]", EditorStyles.boldLabel);

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/Waypoints.unity");
                }

                else if (GUILayout.Button("Deselect"))
                {
                    j[3] = 0;
                    Repaint();
                }
            }

            if (j[4] == 0)
            {
                GUILayout.Label("Waypoint A*");

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/WPTank.unity");
                }

                else if (GUILayout.Button("Select"))
                {
                    j[4] = 1;
                    Repaint();
                }
            }


            else if (j[4] == 1)
            {
                GUILayout.Label("Waypoint A* [SELECTED]", EditorStyles.boldLabel);

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/WPTank.unity");
                }

                else if (GUILayout.Button("Deselect"))
                {
                    j[4] = 0;
                    Repaint();
                }
            }

            if (j[5] == 0)
            {
                GUILayout.Label("Unity Vehicle System");

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/UnityVehicleSys.unity");
                }

                else if (GUILayout.Button("Select"))
                {
                    j[5] = 1;
                    Repaint();
                }
            }


            else if (j[5] == 1)
            {
                GUILayout.Label("Unity Vehicle System [SELECTED]", EditorStyles.boldLabel);

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/UnityVehicleSys.unity");
                }

                else if (GUILayout.Button("Deselect"))
                {
                    j[5] = 0;
                    Repaint();
                }
            }


            GUILayout.Space(10.0f);

            if (GUILayout.Button("Back"))
            {
                i = 2;
                Repaint();
            }


        }
        #endregion

        #region NavMeshPage
        else if (i == 5)
        {
            GUILayout.Label("NavMesh based", EditorStyles.boldLabel);

            if (j[6] == 0)
            {
                GUILayout.Label("Multiple NavMeshes");

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/BridgeTest.unity");
                }

                else if (GUILayout.Button("Select"))
                {
                    j[6] = 1;
                    Repaint();
                }
            }
            else if (j[6] == 1)
            {
                GUILayout.Label("Multiple NavMeshes [SELECTED]", EditorStyles.boldLabel);

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/BridgeTest.unity");
                }

                else if (GUILayout.Button("Deselect"))
                {
                    j[6] = 0;
                    Repaint();
                }
            }

            if (j[7] == 0)
            {
                GUILayout.Label("Basic NavMesh Patrol");

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/NavMeshBasic.unity");
                }

                else if (GUILayout.Button("Select"))
                {
                    j[7] = 1;
                    Repaint();
                }
            }
            else if (j[7] == 1)
            {
                GUILayout.Label("Basic Navmesh Patrol [SELECTED]", EditorStyles.boldLabel);

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/NavMeshBasic.unity");
                }

                else if (GUILayout.Button("Deselect"))
                {
                    j[7] = 0;
                    Repaint();
                }
            }

            if (j[8] == 0)
            {
                GUILayout.Label("NavMeshed Waypoints");

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/WPTankNavMesh.unity");
                }

                else if (GUILayout.Button("Select"))
                {
                    j[8] = 1;
                    Repaint();
                }
            }
            else if (j[8] == 1)
            {
                GUILayout.Label("NavMeshed Waypoints [SELECTED]", EditorStyles.boldLabel);

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/WPTankNavMesh.unity");
                }

                else if (GUILayout.Button("Deselect"))
                {
                    j[8] = 0;
                    Repaint();
                }
            }

            if (j[9] == 0)
            {
                GUILayout.Label("Basic Traversal");

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/stationNavMeshAgent.unity");
                }

                else if (GUILayout.Button("Select"))
                {
                    j[9] = 1;
                    Repaint();
                }
            }
            else if (j[9] == 1)
            {
                GUILayout.Label("Basic Traversal [SELECTED]", EditorStyles.boldLabel);

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/stationNavMeshAgent.unity");
                }

                else if (GUILayout.Button("Deselect"))
                {
                    j[9] = 0;
                    Repaint();
                }
            }

            if (j[10] == 0)
            {
                GUILayout.Label("Weighted Traversal");

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/stationNavMeshAgentRes.unity");
                }

                else if (GUILayout.Button("Select"))
                {
                    j[10] = 1;
                    Repaint();
                }
            }


            else if (j[10] == 1)
            {
                GUILayout.Label("Weighted Traversal [SELECTED]", EditorStyles.boldLabel);

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/stationNavMeshAgentRes.unity");
                }

                else if (GUILayout.Button("Deselect"))
                {
                    j[10] = 0;
                    Repaint();
                }
            }

            if (j[11] == 0)
            {
                GUILayout.Label("Object Tracking");

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/ZombieChaser.unity");
                }

                else if (GUILayout.Button("Select"))
                {
                    j[11] = 1;
                    Repaint();
                }
            }


            else if (j[11] == 1)
            {
                GUILayout.Label("Object Tracking [SELECTED]", EditorStyles.boldLabel);

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/ZombieChaser.unity");
                }

                else if (GUILayout.Button("Deselect"))
                {
                    j[11] = 0;
                    Repaint();
                }
            }

            if (j[12] == 0)
            {
                GUILayout.Label("Point Tracking");

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/ZombieOverview.unity");
                }

                else if (GUILayout.Button("Select"))
                {
                    j[12] = 1;
                    Repaint();
                }
            }


            else if (j[12] == 1)
            {
                GUILayout.Label("Point Tracking [SELECTED]", EditorStyles.boldLabel);

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/ZombieOverview.unity");
                }

                else if (GUILayout.Button("Deselect"))
                {
                    j[12] = 0;
                    Repaint();
                }
            }


            GUILayout.Space(10.0f);

            if (GUILayout.Button("Back"))
            {
                i = 2;
                Repaint();
            }


        }
        #endregion

        #region BasicTrackingPage
        else if (i == 6)
        {
            GUILayout.Label("Basic Tracking", EditorStyles.boldLabel);

            if (j[13] == 0)
            {
                GUILayout.Label("Simple Mover");

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/Moving.unity");
                }

                else if (GUILayout.Button("Select"))
                {
                    j[13] = 1;
                    Repaint();
                }
            }
            else if (j[13] == 1)
            {
                GUILayout.Label("Simple Mover [SELECTED]", EditorStyles.boldLabel);

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/Moving.unity");
                }

                else if (GUILayout.Button("Deselect"))
                {
                    j[13] = 0;
                    Repaint();
                }
            }

            if (j[14] == 0)
            {
                GUILayout.Label("Root Motion Follow");

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/zombie.unity");
                }

                else if (GUILayout.Button("Select"))
                {
                    j[14] = 1;
                    Repaint();
                }
            }
            else if (j[14] == 1)
            {
                GUILayout.Label("Root Motion Follow [SELECTED]", EditorStyles.boldLabel);

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/zombie.unity");
                }

                else if (GUILayout.Button("Deselect"))
                {
                    j[14] = 0;
                    Repaint();
                }
            }

            if (j[15] == 0)
            {
                GUILayout.Label("Basic Follow");

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/petcube.unity");
                }

                else if (GUILayout.Button("Select"))
                {
                    j[15] = 1;
                    Repaint();
                }
            }
            else if (j[15] == 1)
            {
                GUILayout.Label("Basic Follow [SELECTED]", EditorStyles.boldLabel);

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/petcube.unity");
                }

                else if (GUILayout.Button("Deselect"))
                {
                    j[15] = 0;
                    Repaint();
                }
            }
            
            GUILayout.Space(10.0f);

            if (GUILayout.Button("Back"))
            {
                i = 2;
                Repaint();
            }


        }
        #endregion

        #region GroupPage
        else if (i == 7)
        {
            GUILayout.Label("Grouped Behaviors", EditorStyles.boldLabel);

            if (j[16] == 0)
            {
                GUILayout.Label("Bidirectional Flow");

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/crowdBehavior.unity");
                }

                else if (GUILayout.Button("Select"))
                {
                    j[16] = 1;
                    Repaint();
                }
            }
            else if (j[16] == 1)
            {
                GUILayout.Label("Bidirectional Flow [SELECTED]", EditorStyles.boldLabel);

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/crowdBehavior.unity");
                }

                else if (GUILayout.Button("Deselect"))
                {
                    j[16] = 0;
                    Repaint();
                }
            }

            if (j[17] == 0)
            {
                GUILayout.Label("Dynamic Crowd");

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/Crowd.unity");
                }

                else if (GUILayout.Button("Select"))
                {
                    j[17] = 1;
                    Repaint();
                }
            }
            else if (j[17] == 1)
            {
                GUILayout.Label("Dynamic Crowd [SELECTED]", EditorStyles.boldLabel);

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/Crowd.unity");
                }

                else if (GUILayout.Button("Deselect"))
                {
                    j[17] = 0;
                    Repaint();
                }
            }

            if (j[18] == 0)
            {
                GUILayout.Label("Fleeing Crowd");

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/crowdFleeing.unity");
                }

                else if (GUILayout.Button("Select"))
                {
                    j[18] = 1;
                    Repaint();
                }
            }

            else if (j[18] == 1)
            {
                GUILayout.Label("Fleeing Crowd [SELECTED]", EditorStyles.boldLabel);

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/crowdFleeing.unity");
                }
                else if (GUILayout.Button("Deselect"))
                {
                    j[18] = 0;
                    Repaint();
                }
            }

            if (j[19] == 0)
            {
                GUILayout.Label("Basic Flock");

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/Swimming.unity");
                }

                else if (GUILayout.Button("Select"))
                {
                    j[19] = 1;
                    Repaint();
                }
            }
            else if (j[19] == 1)
            {
                GUILayout.Label("Basic Flock [SELECTED]", EditorStyles.boldLabel);

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/Swimming.unity");
                }
                else if (GUILayout.Button("Deselect"))
                {
                    j[19] = 0;
                    Repaint();
                }
            }

            if (j[20] == 0)
            {
                GUILayout.Label("Aware Flock");

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/SwimmingObstacle.unity");
                }

                else if (GUILayout.Button("Select"))
                {
                    j[20] = 1;
                    Repaint();
                }
            }
            else if (j[20] == 1)
            {
                GUILayout.Label("Aware Flock [SELECTED]", EditorStyles.boldLabel);

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/SwimmingObstacle.unity");
                }
                else if (GUILayout.Button("Deselect"))
                {
                    j[20] = 0;
                    Repaint();
                }
            }


            GUILayout.Space(10.0f);
                   
            if (GUILayout.Button("Back"))
            {
                i = 3;
                Repaint();
            }


        }
        #endregion

        #region FSMPage
        else if (i == 8)
        {
            if (j[21] == 0)
            {
                GUILayout.Label("Finite State Machines", EditorStyles.boldLabel);
                GUILayout.Space(10.0f);
                GUILayout.Label("Examples");

                if (GUILayout.Button("Robot Guard"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/RobotGuard.unity");
                }
                if (GUILayout.Button("Tanks : WP Based"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/TanksFSMWP.unity");
                }
                if (GUILayout.Button("Tanks : NM Based"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/TanksFSMNavMesh.unity");
                }

                GUILayout.Space(10.0f);
                GUILayout.Label("Selection");
                if (GUILayout.Button("Select"))
                {
                    j[21] = 1;
                    Repaint();
                }
            }
            else if (j[21] == 1)
            {
                GUILayout.Label("Finite State Machines [SELECTED]", EditorStyles.boldLabel);
                GUILayout.Space(10.0f);
                GUILayout.Label("Examples");

                if (GUILayout.Button("Robot Guard"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/RobotGuard.unity");
                }
                if (GUILayout.Button("Tanks : WP Based"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/TanksFSMWP.unity");
                }
                if (GUILayout.Button("Tanks : NM Based"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/TanksFSMNavMesh.unity");
                }

                GUILayout.Space(10.0f);
                GUILayout.Label("Selection");
                if (GUILayout.Button("Deselect"))
                {
                    j[21] = 0;
                    Repaint();
                }
            }

            GUILayout.Space(10.0f);

            if (GUILayout.Button("Back"))
            {
                i = 3;
                Repaint();
            }


        }
        #endregion

        #region BTPage
        else if (i == 9)
        {
            if (j[22] == 0)
            {
                GUILayout.Label("Behavior Trees", EditorStyles.boldLabel);
                GUILayout.Space(10.0f);
                //GUILayout.Label("Examples");

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/RoversBT.unity");
                }

                else if (GUILayout.Button("Select"))
                {
                    j[22] = 1;
                    Repaint();
                }
            }
            else if (j[22] == 1)
            {
                GUILayout.Label("Behavior Trees [SELECTED]", EditorStyles.boldLabel);
                GUILayout.Space(10.0f);
               // GUILayout.Label("Examples");

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/RoversBT.unity");
                }

                else if (GUILayout.Button("Deselect"))
                {
                    j[22] = 0;
                    Repaint();
                }
            }

            GUILayout.Space(10.0f);

            if (GUILayout.Button("Back"))
            {
                i = 3;
                Repaint();
            }


        }
        #endregion

        #region GOAPPage
        else if (i == 10)
        {
            if (j[23] == 0)
            {
                GUILayout.Label("Goal Oriented Action Plan", EditorStyles.boldLabel);
                GUILayout.Space(10.0f);
                //GUILayout.Label("Examples");

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/village.unity");
                }

                else if (GUILayout.Button("Select"))
                {
                    j[23] = 1;
                    Repaint();
                }
            }
            else if (j[23] == 1)
            {
                GUILayout.Label("Goal Oriented Action Plan [SELECTED]", EditorStyles.boldLabel);
                GUILayout.Space(10.0f);
                // GUILayout.Label("Examples");

                if (GUILayout.Button("Playtest"))
                {
                    EditorSceneManager.OpenScene("Assets/Symper/Scenes/village.unity");
                }

                else if (GUILayout.Button("Deselect"))
                {
                    j[23] = 0;
                    Repaint();
                }
            }

            GUILayout.Space(10.0f);

            if (GUILayout.Button("Back"))
            {
                i = 3;
                Repaint();
            }


        }
        #endregion

    }
}
