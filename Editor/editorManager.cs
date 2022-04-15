using System.Collections;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(CharacterData))]
public class editorManager : Editor
{
    public override void OnInspectorGUI()
    {


        DrawDefaultInspector();

        EditorGUILayout.HelpBox("Please confirm all info\nBecarefuel this tool can change some Objects tags and name.", MessageType.Info);

        CharacterData characterData = (CharacterData)target;


        if (GUILayout.Button("Create Enemy"))
        {
            characterData.createAnEnemy();
        }


    }



}
