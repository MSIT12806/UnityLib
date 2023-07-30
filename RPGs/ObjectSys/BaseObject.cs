using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.ObjectSystem
{
    public class Base
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public abstract class SceneObject: Base
    {
        public float Mass { get; set; }
        public Vector3 Position { get; set; }
        public abstract void Destroy();//退場機制?
    }

    //消耗品  //這算不算UI啊？
}
