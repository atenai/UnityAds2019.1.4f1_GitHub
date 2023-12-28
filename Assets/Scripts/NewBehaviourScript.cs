using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class NewBehaviourScript : MonoBehaviour
{
    [Range(1, 10)]
    public int num1 = 1;

    [Range(1, 10)]
    public float num2 = 1;

    [Range(1, 10)]
    public long num3 = 1;

    [Range(1, 10)]
    public double num4 = 1;

    void OnEnable()
    {
#if UNITY_EDITOR

#endif
    }
}
