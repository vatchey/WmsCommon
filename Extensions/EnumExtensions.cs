using System.ComponentModel;

namespace WmsCommon.Extensions
{
   public static class EnumExtensions
   {
      public static string GetDescription(this Enum value)
      {
         var field = value.GetType().GetField(value.ToString());

         if (field != null)
         {
            var attr = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
            if (attr != null)
            {
               return attr.Description;
            }
         }

         //if we're here, we didn't find a description attribute, so just return the value
         return value.ToString();
      }
   }
}