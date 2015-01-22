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
   public class ForestBrushElementInstance : SimObjectInstance
   {
      public ForestBrushElementInstance(string _name = "", string _className = "ForestBrushElement", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float elevationMax
      {
         set { Fields["elevationMax"] = value.ToString(); }
      }

      public float elevationMin
      {
         set { Fields["elevationMin"] = value.ToString(); }
      }

      public ForestItemData forestItemData
      {
         set { Fields["forestItemData"] = value.ToString(); }
      }

      public float probability
      {
         set { Fields["probability"] = value.ToString(); }
      }

      public float rotationRange
      {
         set { Fields["rotationRange"] = value.ToString(); }
      }

      public float scaleExponent
      {
         set { Fields["scaleExponent"] = value.ToString(); }
      }

      public float scaleMax
      {
         set { Fields["scaleMax"] = value.ToString(); }
      }

      public float scaleMin
      {
         set { Fields["scaleMin"] = value.ToString(); }
      }

      public float sinkMax
      {
         set { Fields["sinkMax"] = value.ToString(); }
      }

      public float sinkMin
      {
         set { Fields["sinkMin"] = value.ToString(); }
      }

      public float sinkRadius
      {
         set { Fields["sinkRadius"] = value.ToString(); }
      }

      public float slopeMax
      {
         set { Fields["slopeMax"] = value.ToString(); }
      }

      public float slopeMin
      {
         set { Fields["slopeMin"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator ForestBrushElement(ForestBrushElementInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         ForestBrushElement ret = new ForestBrushElement();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(ForestBrushElementInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
