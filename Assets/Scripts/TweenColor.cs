using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEditor;
using UnityEngine;

[AddComponentMenu("MyUI/Tween Color")]
public class TweenColor : MonoBehaviour
{
    void Start()
    {
        Debug.Log(JsonUtility.ToJson(new Example(), true));

        var list = new List<Example>
        {
            new Example(),
            new Example()
        };

        Debug.Log(JsonUtility.ToJson(list));
    }

    public static string ToJson(string key, Object[] objs)
    {
        var json = objs.Select(obj => EditorJsonUtility.ToJson(obj)).ToArray();
        var values = string.Join(",", json);
        return string.Format("{\"{0}\":{1}]}", key, values);
    }


}
