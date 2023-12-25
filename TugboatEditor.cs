using UnityEditor;
using UnityEngine;

namespace FishNet.Transporting.Tugboat
{
    [CustomEditor(typeof(Tugboat))]
    public class TugboatEditor : Editor
    {
        private Tugboat _tugboat;

        private void OnEnable()
        {
            _tugboat = (Tugboat) target;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (GUILayout.Button("Connect Client"))
            {
                _tugboat.StartConnection(false);
            }
        }
    }
}