using System;

namespace equalsimplementation
{
    public class Programobject
    {
          public virtual bool EqualsMethod(Object obj)
          {
              // The given object to compare cant be null
              if (obj == null)
              {
                  Console.WriteLine("object is not null");
                  return false;
              }
              // If objects are of different types
              if(this.GetType() != obj.GetType())
              {
                  Console.WriteLine("objects are of different types");
                  Console.WriteLine("since objects are of different types, their references are not equal");
                  return false;
              }
              // If objects are of same type, return true
              else
              {
                  Console.WriteLine("objects are of same types");
                
              
          
                  if(obj==this)
                  {
                  Console.WriteLine("References are equal");
                  return true;
                  }
                  else
                  {
                      Console.WriteLine("References are not equal");
                      return false;
                  }
              }

          }
          public class Program 
          {
              static void Main(string[] args)
              {
                
                
                  Programobject i = new Programobject();
                  Programobject p = new Programobject();
                  Program o = new Program();
                  Console.WriteLine("TO COMPARE 2 DIFFERENT OBJECTS");
                  i.EqualsMethod(p);
                  // now equate 2 objects
                  Console.WriteLine("TO EQUATE 2 DIFFERENT OBJECTS BY EQUATING THEM");
                  i=p;
                  p.EqualsMethod(i);

                  Console.WriteLine("TO EQUATE 2 DIFFERENT OBJECTS OF DIFFERENT TYPES");
                  i.EqualsMethod(o);

              
              
        
          }
        }
    }
}
