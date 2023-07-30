using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Ron.Base.Extension
{
    public static class Vector3IntExtension
    {
        public static Vector3Int Copy(this Vector3Int v1)
        {
            return new Vector3Int(v1.x, v1.y, v1.z);
        }
        public  static Vector3Int AddX(this Vector3Int val, int x)
        {
            var r = val.Copy();
            r.x += x;
            return r;
        }
        public  static Vector3Int AddY(this Vector3Int val, int y)
        {
            var r = val.Copy();
            r.y += y;
            return r;
        }
        public  static Vector3Int AddZ(this Vector3Int val, int z)
        {
            var r = val.Copy();
            r.z += z;
            return r;
        }
        public static Vector3Int WithY(this Vector3Int val, int yVal = 0)
        {
            var r = val.Copy();
            r.y = yVal;
            return r;
        }
        public static Vector3Int WithX(this Vector3Int val, int xVal = 0)
        {
            var r = val.Copy();
            r.x = xVal;
            return r;
        }
        public static Vector3Int WithZ(this Vector3Int val, int xVal = 0)
        {
            var r = val.Copy();
            r.z = xVal;
            return r;
        }
    }
    public static class Vector3Extension
    {
        public static Vector3 AlmostEqual(this Vector3 val, Vector3 target, float limitDistance)
        {
            if (Vector3.Distance(val, target) < limitDistance)
            {
                return target;
            }
            else
            {
                return val;
            }

        }
        public static Vector3 WithY(this Vector3 val, float yVal = 0)
        {
            var r = val;
            r.y = yVal;
            return r;
        }
        public static Vector3 WithX(this Vector3 val, float xVal = 0)
        {
            var r = val;
            r.x = xVal;
            return r;
        }
        public static Vector3 AddY(this Vector3 val, float addVal)
        {
            val.y += addVal;
            return val;
        }
        public static Vector3 GetLocalRight(this Vector3 forward)
        {
            return Vector3.Cross(forward.normalized, Vector3.up);
        }
        public static Vector3 GetLocalUp(this Vector3 forward)
        {
            return Vector3.Cross(forward.normalized, Vector3.right);
        }
        public static Vector3 GetRandomDirection()
        {
            return new Vector3(UnityEngine.Random.value - 0.5f, UnityEngine.Random.value - 0.5f, UnityEngine.Random.value - 0.5f);
        }
        public static Vector3 GetDirection(Vector3 from, Vector3 to)
        {
            return (to - from).normalized;
        }
        public static Vector3 GetVector(Vector3 from, Vector3 to)
        {
            return (to - from);
        }
        public static Vector3Int ToV3Int(this Vector3 self)
        {
            int x = Mathf.RoundToInt(self.x);
            int y = Mathf.RoundToInt(self.y);
            int z = Mathf.RoundToInt(self.z);
            return new Vector3Int(x, y, z);
        }
        public static System.Numerics.Vector3 ToSystemVector3(this Vector3 unityVector)
        {
            return new System.Numerics.Vector3(unityVector.x, unityVector.y, unityVector.z);
        }
        public static Vector3 ToUnityVector3(this System.Numerics.Vector3 systemVector)
        {
            return new Vector3(systemVector.X, systemVector.Y, systemVector.Z);
        }
    }
}