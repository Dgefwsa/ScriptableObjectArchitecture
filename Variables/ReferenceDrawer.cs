using UnityEngine;
using UnityEditor;

namespace Variables
{
    [CustomPropertyDrawer(typeof(IntReference))]
    [CustomPropertyDrawer(typeof(FloatReference))]
    [CustomPropertyDrawer(typeof(StringReference))]
    [CustomPropertyDrawer(typeof(ListReference<>))]
    public class ReferenceDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            //base.OnGUI(position, property, label);

            EditorGUI.BeginProperty(position, label, property);
            EditorGUILayout.BeginVertical("box");
            var boolRect = new Rect(position.x, position.y, position.width, position.height);
            var amountRect = new Rect(position.x + 35, position.y, position.width, position.height);
            var fieldName = property.name;
            var isConstant = property.FindPropertyRelative("UseConstant").boolValue;
            var valueType = property.FindPropertyRelative("ConstantValue").type;
            EditorGUILayout.LabelField($"{fieldName} : {valueType}");
            EditorGUILayout.BeginHorizontal("box");
            EditorGUILayout.PropertyField(property.FindPropertyRelative("UseConstant"));
            if (isConstant)
            {
                
                EditorGUILayout.PropertyField(property.FindPropertyRelative("ConstantValue"), GUIContent.none);
            }
            else
            {
                EditorGUILayout.PropertyField(property.FindPropertyRelative("Variable"), GUIContent.none);
            }
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.EndVertical();
            EditorGUI.EndProperty();
        }
    }
}