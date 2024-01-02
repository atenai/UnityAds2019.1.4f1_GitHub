using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ExampleWindow : EditorWindow
{
    int intervalTime = 60;

    const string AUTO_SAVE_INTERVAL_TIME = "AutoSaveinterval time (sec)";

    [MenuItem("Window/Example")]//Unityエディタの上にあるWindowメニューに追加される
    static void Open()
    {
        GetWindow<ExampleWindow>();
    }

    void OnEnable()
    {
        intervalTime = EditorPrefs.GetInt(AUTO_SAVE_INTERVAL_TIME, 60);//ロード
    }

    void OnGUI()
    {
        EditorGUI.BeginChangeCheck();//Inspectorで要素が変更されたかどうかを確認する

        //シーン自動保存間隔（秒）
        intervalTime = EditorGUILayout.IntSlider("間隔（秒）", intervalTime, 1, 3600);

        if (EditorGUI.EndChangeCheck() == true)//Inspectorで要素が変更された場合は、中身を実行する
        {
            EditorPrefs.SetInt(AUTO_SAVE_INTERVAL_TIME, intervalTime);//セーブ
        }
    }
}
