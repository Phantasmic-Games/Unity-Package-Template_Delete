using UnityEditor;
using UnityEngine;

namespace PhantasmicDev.PackageTemplate.Editor
{
    /// <summary>
    /// This is a dummy script used for generating Editor documentation.
    /// </summary>
    [CustomEditor(typeof(PlaceholderMonoBehaviour))]
    public class PlaceholderEditor : UnityEditor.Editor
    {
        private SerializedProperty m_SpeedProp;

        private void OnEnable()
        {
            m_SpeedProp = serializedObject.FindProperty("m_Speed");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            EditorGUILayout.PropertyField(m_SpeedProp);

            serializedObject.ApplyModifiedProperties();
        }

        /// <summary>
        /// Returns an array of all loaded PlaceholderMonobehaviours.
        /// </summary>
        /// <returns></returns>
        public static PlaceholderMonoBehaviour[] GetAllPlaceholderMonoBehaviours()
        {
            return FindObjectsByType<PlaceholderMonoBehaviour>(FindObjectsSortMode.None);
        }
    }
}
