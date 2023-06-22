using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ron.Tools.Unity
{
    public static class GetComponent
    {
        public static T GetImplement<T>(string gameObjectName, string componentName) 
        {
            GameObject obj = GameObject.Find(gameObjectName); // 在 hierarchy 中尋找指定名稱的物件

            if (obj != null)
            {
                Component component = obj.GetComponent(componentName); // 取得指定組件名稱的組件

                if (component != null && component is T implement)
                {
                    return implement; // 回傳符合 介面的組件
                }
            }

            return default(T); // 若找不到符合條件的組件，回傳 null
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Transform FindOffspring(this Transform parent, string name)
        {
            Transform result = parent.Find(name);

            if (result != null)
                return result;

            foreach (Transform child in parent)
            {
                result = FindOffspring(child, name);
                if (result != null)
                    return result;
            }

            return null;
        }
    }

}