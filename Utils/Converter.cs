using System.Runtime.InteropServices;
using MessagePack;


namespace WmsCommon.Utils
{
   public class Converter
   {
      public static string LastErrorMsg { get; private set; } = string.Empty;


      /// <summary>
      /// StructValuesToBytes() (used between Managed types)
      /// 
      /// ** converts a struct consisting ONLY OF VALUE TYPES to a byte array
      /// *** for managed types
      /// </summary>
      public static byte[]? StructValuesToBytes<T>(T st) where T : struct
      {
         byte[]? bytes = null;

         try
         {
            bytes = new byte[Marshal.SizeOf<T>()];

            MemoryMarshal.Write(bytes, ref st);
         }
         catch (Exception ex)
         {
            LastErrorMsg = $"Exception caught: {ex.Message}";
         }

         return bytes;
      }


      /// <summary>
      /// PackToBytes() (used between Managed types)
      /// 
      /// * uses MessagePack to serialize an object to a byte array
      /// ** object must have the [MessagePackObject] attribute
      /// </summary>
      public static byte[]? PackToBytes<T>(T obj)
      {
         byte[]? bytes = null;

         if (obj == null)
         {
            LastErrorMsg = "Object is null";
            return bytes;
         }

         try
         {
            // we need to serialize the object using nuget package MessagePack ....
            bytes = MessagePackSerializer.Serialize(obj);
         }
         catch (MessagePackSerializationException ex)
         {
            LastErrorMsg = $"PackToBytes() - failed to serialize object: {ex.Message}";
         }

         return bytes;
      }

      /// <summary>
      /// UnpackFromBytes() (used between Managed/Unmanaged types)
      /// 
      /// </summary>
      public static byte[]? ToUnmanagedBytes<T>(T obj)
      {
         byte[]? bytes = null;

         if (obj == null)
         {
            LastErrorMsg = "ToUnmanagedBytes() Object is null";
            return bytes;
         }

         // convert object to unmanaged bytes....
         try
         {
            int size = Marshal.SizeOf(obj);
            bytes = new byte[size];

            IntPtr ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(obj, ptr, false);
            Marshal.Copy(ptr, bytes, 0, size);
            Marshal.FreeHGlobal(ptr);
         }
         catch (Exception ex)
         {
            LastErrorMsg = $"ToUnmanagedBytes() - failed to convert object to unmanaged bytes: {ex.Message}";
         }

         return bytes;
      }


   }
}