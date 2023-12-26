using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class ResouceLoad : MonoBehaviour
{
    void Start()
    {
        TestIconLoad();
    }

    void Update()
    {

    }

    void TestIconLoad()
    {
        UnityEngine.Texture tex = EditorGUIUtility.Load("Icon.png") as Texture;
        Debug.Log(tex);
    }
}
