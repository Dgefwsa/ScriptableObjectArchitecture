using System;

namespace Variables
{
    [Serializable]
    public abstract class SetReference<T>
    {
        public bool UseConstant;
        public SetVariable<T> Variable;
    }
}