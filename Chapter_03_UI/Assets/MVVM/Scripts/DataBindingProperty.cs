public class DataBindingProperty<T>
{
    public delegate void ValueModifiedHandler(T prevValue, T curValue);
    public ValueModifiedHandler OnValueModified;

    private T _value;
    
    public T Value
    {
        get
        {
            return _value;
        }
        set
        {
            if (object.Equals(_value, value))
            {
                return;
            }

            T prevValue = _value;
            _value = value;
            ValueModified(prevValue, _value);
        }
    }

    private void ValueModified(T prevValue, T curValue)
    {
        if (OnValueModified == null)
        {
            return;
        }
        OnValueModified(prevValue, curValue);
    }
}
