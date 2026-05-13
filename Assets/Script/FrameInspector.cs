using UnityEditor;
using UnityEngine;
using System.Collections.Generic;

namespace Script
{
    [CustomEditor(typeof(FrameViewer))]
    public class FrameInspector : Editor
    {
        private bool showFrames = true;

        public override void OnInspectorGUI()
        {
            EditorGUILayout.LabelField("Frames Debug Viewer", EditorStyles.boldLabel);

            var frames = FramesInfo.frames;

            if (frames == null || frames.Count == 0)
            {
                EditorGUILayout.HelpBox("No frame data available.", MessageType.Info);
                return;
            }

            showFrames = EditorGUILayout.Foldout(showFrames, $"Frames ({frames.Count})");

            if (!showFrames) return;

            foreach (KeyValuePair<int, FrameDetail> kvp in frames)
            {
                EditorGUILayout.BeginVertical("box");

                EditorGUILayout.LabelField("Frame Index", kvp.Key.ToString());

                var frame = kvp.Value;

                EditorGUILayout.Vector3Field("Position", frame.position);
                EditorGUILayout.FloatField("HP", frame.HP);
                EditorGUILayout.IntField("Ammo", frame.ammo);

                EditorGUILayout.EndVertical();
            }
        }
    }
}