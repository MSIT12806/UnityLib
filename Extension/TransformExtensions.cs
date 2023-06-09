using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ron
{
    public static class TransformExtensions 
    {
        public static T FindAnyChild<T>(this Transform trans, string name) where T : Component
        {
            if (trans.name == name) return trans.GetComponent<T>();


            for (var n = 0; n < trans.childCount; n++)
            {
                if (trans.GetChild(n).childCount > 0)
                {
                    var child = trans.GetChild(n).FindAnyChild<Transform>(name);
                    if (child != null)
                        return child.GetComponent<T>();
                }
                if (trans.GetChild(n).name == name)
                {
                    return trans.GetChild(n).GetComponent<T>();
                }
            }
            return default;
        }
    }
}