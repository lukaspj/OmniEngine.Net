using System;
using System.Collections.Generic;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Engine.Classes.View.Creators
{
   /// <summary>
   /// 
   /// </summary>
   public class SimObjectInstanceTest : ObjectInstance
   {
      public SimObjectInstanceTest(string _name = "", ObjectType pObjectType = ObjectType.Instance)
         : base("SimObject", _name, pObjectType)
      {
         
      }
      protected SimObjectInstanceTest(string className, string _name = "", ObjectType pObjectType = ObjectType.Instance)
         : base(className, _name, pObjectType)
      {

      }

   }

   public class SFXSourceInstanceTest : SimObjectInstanceTest
   {
      public SFXSourceInstanceTest(string _name = "")
         : base("SFXSource", _name)
      {
      }

      public TypeSFXDescriptionName _description
      {
         set { Fields["description"] = value.ToString(); }
      }

      private FieldWrapper<String> __statusCallback;
      public FieldWrapper<String> _statusCallback
      {
         get { return __statusCallback; }
         set
         {
            __statusCallback.Set(ref mFieldsDictionary, "statusCallback");
            __statusCallback = value;
         }
      }
   }
}