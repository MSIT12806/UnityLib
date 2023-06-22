using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Ron.Base.Extension
{
    public abstract class Computable<T> : IComparer<T> where T : Computable<T>
    {
        public abstract int Compare(T x, T y);
        /// <summary>
        /// you need override this when use hash table.
        /// </summary>
        public abstract override int GetHashCode();
        public abstract override bool Equals(object obj);
        public static bool operator ==(Computable<T> left, Computable<T> right) => left.Equals(right);
        public static bool operator !=(Computable<T> left, Computable<T> right) => left.Equals(right) == false;
        public abstract bool BiggerThen(Computable<T> target);
        public static bool operator >(Computable<T> left, Computable<T> right) => left.BiggerThen(right);
        public static bool operator <(Computable<T> left, Computable<T> right) => left.BiggerThen(right) == false;
        public abstract T Add(T target);
        public static T operator +(Computable<T> s, T t) => s.Add(t);
        public abstract T Reduce(T target);
        public static T operator -(Computable<T> s, T t) => s.Reduce(t);
        public abstract T Multipy(T target);
        public static T operator *(Computable<T> s, T t) => s.Multipy(t);
        public abstract T Divide(T target);
        public static T operator /(Computable<T> s, T t) => s.Divide(t);

    }
    public static class BasicExtension
    {
        public static bool Not(this bool condition)
        {
            return !condition;
        }

        /// <summary>
        /// 無條件捨去後轉成int
        /// </summary>
        public static int ToIntTruncate(this float value)
        {
            return (int)value;
        }
    }
}
