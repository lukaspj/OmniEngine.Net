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
   public class RiverInstance : WaterObjectInstance
   {
      public RiverInstance(string _name = "", string _className = "River", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float FlowMagnitude
      {
         set { Fields["FlowMagnitude"] = value.ToString(); }
      }

      public float LowLODDistance
      {
         set { Fields["LowLODDistance"] = value.ToString(); }
      }

      public String Node
      {
         set { Fields["Node"] = value.ToString(); }
      }

      public float SegmentLength
      {
         set { Fields["SegmentLength"] = value.ToString(); }
      }

      public float SubdivideLength
      {
         set { Fields["SubdivideLength"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator River(RiverInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         River ret = new River();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(RiverInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
