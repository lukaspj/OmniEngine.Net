using System;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;

namespace WinterLeaf.Demo.Full.Models.Base.Creators
{
   /// <summary>
   /// 
   /// </summary>
   public class SimObjectInstance : ObjectInstance
   {
      public SimObjectInstance(string _name = "", string _className = "SimObject", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool canSave
      {
         set { Fields["canSave"] = value.ToString(); }
      }

      public bool canSaveDynamicFields
      {
         set { Fields["canSaveDynamicFields"] = value.ToString(); }
      }

      public String classx
      {
         set { Fields["class"] = value.ToString(); }
      }

      public String className
      {
         set { Fields["className"] = value.ToString(); }
      }

      public bool editable
      {
         set { Fields["editable"] = value.ToString(); }
      }

      public bool Enabled
      {
         set { Fields["Enabled"] = value.ToString(); }
      }

      public bool hidden
      {
         set { Fields["hidden"] = value.ToString(); }
      }

      public String internalName
      {
         set { Fields["internalName"] = value.ToString(); }
      }

      public bool lockedx
      {
         set { Fields["locked"] = value.ToString(); }
      }

      public TypeName name
      {
         set { Fields["name"] = value.ToString(); }
      }

      public SimObject parentGroup
      {
         set { Fields["parentGroup"] = value.ToString(); }
      }

      public int persistentId
      {
         set { Fields["persistentId"] = value.ToString(); }
      }

      public String superClass
      {
         set { Fields["superClass"] = value.ToString(); }
      }

      public int WLE_OMNI_ARRAY_POSTION
      {
         set { Fields["WLE_OMNI_ARRAY_POSTION"] = value.ToString(); }
      }

      public String WLE_OVERRIDE_PROXY_CLASSTYPE
      {
         set { Fields["WLE_OVERRIDE_PROXY_CLASSTYPE"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator SimObject(SimObjectInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         SimObject ret = new SimObject();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(SimObjectInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
