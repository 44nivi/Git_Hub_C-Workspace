/* 

Example 1: Retrieves the Type object for MyClass using typeof(), and prints its full name.

Example 2: Creates an instance of MyClass dynamically using Activator.CreateInstance. Then, it sets the Name and Age properties using a helper method SetProperty.

Example 3: Retrieves the MethodInfo object for the SayHello method and invokes it on the created instance myObject.

Example 4: Retrieves all properties of MyClass using GetProperties, and iterates over them to print their names, types, and current values.
 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Log4Net.CSharp
{
    internal class Reflection_demo
    {
        public static void Main(string[] args)
        {
              
                // Example 1: Inspect metadata and retrieve type information
                Type myType = typeof(ReflectionFunction);
                Type[] types = new Type[1];

            Console.WriteLine($"Type: {myType.FullName}");
                Console.WriteLine("Assembly"+myType.Assembly);

       /*     ConstructorInfo constructorInfoObj = myType.GetConstructor(
                BindingFlags.Instance | BindingFlags.Public, null,
                CallingConventions.HasThis, types, null);*/
           
            
            // Example 2: Create an instance of MyClass dynamically
            object myObject = Activator.CreateInstance(myType);
                SetProperty(myObject, "Name", "John Doe");
                SetProperty(myObject, "Age", 30);

                // Example 3: Invoke a method (SayHello) dynamically
                MethodInfo methodInfo = myType.GetMethod("SayHello");
                methodInfo.Invoke(myObject, null);

                // Example 4: Discovering properties and invoking them dynamically
                PropertyInfo[] properties = myType.GetProperties();
                foreach (var property in properties)
                {
                    Console.WriteLine($"Property Name: {property.Name}, Type: {property.PropertyType}, Value: {property.GetValue(myObject)}");
                }
                Console.ReadLine();
            }

            static void SetProperty(object obj, string propertyName, object value)
            {
                PropertyInfo propInfo = obj.GetType().GetProperty(propertyName);
                if (propInfo != null && propInfo.CanWrite)
                {
                    propInfo.SetValue(obj, value);
                }
            }

        
    }
}
