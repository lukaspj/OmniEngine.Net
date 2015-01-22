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
   public class ReflectorDescInstance : SimDataBlockInstance
   {
      public ReflectorDescInstance(string _name = "", string _className = "ReflectorDesc", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float detailAdjust
      {
         set { Fields["detailAdjust"] = value.ToString(); }
      }

      public float farDist
      {
         set { Fields["farDist"] = value.ToString(); }
      }

      public int maxRateMs
      {
         set { Fields["maxRateMs"] = value.ToString(); }
      }

      public float nearDist
      {
         set { Fields["nearDist"] = value.ToString(); }
      }

      public int objectTypeMask
      {
         set { Fields["objectTypeMask"] = value.ToString(); }
      }

      public float priority
      {
         set { Fields["priority"] = value.ToString(); }
      }

      public int texSize
      {
         set { Fields["texSize"] = value.ToString(); }
      }

      public int type
      {
         set { Fields["type"] = value.ToString(); }
      }

      public bool useOcclusionQuery
      {
         set { Fields["useOcclusionQuery"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator ReflectorDesc(ReflectorDescInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         ReflectorDesc ret = new ReflectorDesc();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(ReflectorDescInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
