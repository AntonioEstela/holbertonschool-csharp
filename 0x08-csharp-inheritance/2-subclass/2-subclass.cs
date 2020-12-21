using System;

/// <summary>Provides some methods to work with Obj</summary>
class Obj
{
    /// <summary>Method that checks if the object is an instance of a class that inherits from the specified class.</summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}