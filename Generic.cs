using System;
using System.Collections.Generic;
using System.Text;

namespace GenericOdev
{
    class Generic<TKey,TValue >
    {
        TKey[] Key;
    TValue[] Value;
    TKey[] TempKey;
    TValue[] TempValue;

    public Generic()
    {
        Key = new TKey[0];
        Value = new TValue[0];
    }


    public void Add(TKey key, TValue value)
    {
        TempKey = Key;
        TempValue = Value;

        Key = new TKey[Key.Length + 1];
        Value = new TValue[Value.Length + 1];

        for (int i = 0; i < TempKey.Length; i++)
            {
            Key[i] = TempKey[i];
            Value[i] = TempValue[i];
        }

        Key[Key.Length - 1] = key;
        Value[Value.Length - 1] = value;

    }
    public void ToList()
    {
        for (int i = 0; i<Key.Length; i++)
            {
            Console.WriteLine(Key[i] +" -> "+Value[i]);
        }
    }
}
}