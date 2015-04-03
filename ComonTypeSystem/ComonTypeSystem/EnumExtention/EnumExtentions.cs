namespace ComonTypeSystem.EnumExtention
{
    using System;
    using System.Linq;
    using System.ComponentModel;

   public static class EnumExtentions
   {
       public static T GetAttribute<T>(this Enum value)
           where T : Attribute
       {
           var type = value.GetType();
           var name = Enum.GetName(type, value);
           return type.GetField(name)
               .GetCustomAttributes(false)
               .OfType<T>()
               .SingleOrDefault();
       }
       public static String GetDescription(this Enum value)
       {
           var description = GetAttribute<DescriptionAttribute>(value);
           return description != null ? description.Description : null;
       }
    }
}
