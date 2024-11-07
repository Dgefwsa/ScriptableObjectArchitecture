using System;
using System.Collections.Generic;

namespace Variables
{
    [Serializable]
    public class ListReference<T>
    {
        public bool UseConstant;
        public ListVariable<T> Variable;
        public List<T> ConstantValue;

        public ListReference()
        { }
        public ListReference(List<T> value)
        {
            UseConstant = true;
            ConstantValue = value;
        }
        public List<T> Value
        {
            get {return UseConstant ? ConstantValue : Variable.Items;}
        }
    }
}