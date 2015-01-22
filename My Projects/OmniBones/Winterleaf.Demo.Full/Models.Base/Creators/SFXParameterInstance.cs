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
   public class SFXParameterInstance : SimObjectInstance
   {
      public SFXParameterInstance(string _name = "", string _className = "SFXParameter", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public TypeSFXChannel channel
      {
         set { Fields["channel"] = value.ToString(); }
      }

      public float defaultValue
      {
         set { Fields["defaultValue"] = value.ToString(); }
      }

      public String description
      {
         set { Fields["description"] = value.ToString(); }
      }

      public Point2F range
      {
         set { Fields["range"] = value.ToString(); }
      }

      public float value
      {
         set { Fields["value"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator SFXParameter(SFXParameterInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         SFXParameter ret = new SFXParameter();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(SFXParameterInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
