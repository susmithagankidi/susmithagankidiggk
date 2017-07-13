using System;

namespace assignment5
{

public class Method
{
    public Type operation(Type type)
    {
        Console.WriteLine("Inheritance Hierarchies \n");
        while (type!=null)
        {
            Console.WriteLine(type.Name);
            type=type.BaseType;
            
        }
        return type;
    }
    public bool comparing(object obj,Type type)
    {
        Console.WriteLine("testing compatibility \n");
        if (obj.GetType()== type)
        {
            Console.WriteLine("Compatible");
            return true;
        }
        Type t = obj.GetType().BaseType;
        while(t!= typeof(object))
        {
            if (t == type)
            {
                Console.WriteLine("Compatible");
                return true;
            }
            t=t.BaseType;
        }
        if (t==type)
        {
            Console.WriteLine("Compatible");
            return true;
        }
        Console.WriteLine("Not Compatible");
        return false;

    }
        
}
}