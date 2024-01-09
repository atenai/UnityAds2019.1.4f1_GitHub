using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using TMPro;

public class ExampleAsset : ScriptableObject
{
    [MenuItem("Example/CreateExampleAsset Instance")]
    static void CreateExampleAssetInstance()
    {
        var exampleAsset = CreateInstance<ExampleAsset>();
    }
}
