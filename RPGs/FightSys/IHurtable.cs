using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.UnityLib.RPGs.FightSys
{
    public interface IHurtable
    {
        void GetHurt(float hurtValue);
    }

    public interface IAttackable
    {
        float Attack();
    }
}
