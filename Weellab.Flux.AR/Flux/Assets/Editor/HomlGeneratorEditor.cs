using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(HomlGenerator))]
public class HomlGeneratorEditor : Editor {

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        HomlGenerator myGenerator = (HomlGenerator)target;
        if (GUILayout.Button("Generate HOML file"))
            myGenerator.Generate();
    }
}
