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
   public class LightDescriptionInstance : SimDataBlockInstance
   {
      public LightDescriptionInstance(string _name = "", string _className = "LightDescription", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float animationPeriod
      {
         set { Fields["animationPeriod"] = value.ToString(); }
      }

      public float animationPhase
      {
         set { Fields["animationPhase"] = value.ToString(); }
      }

      public LightAnimData animationType
      {
         set { Fields["animationType"] = value.ToString(); }
      }

      public float brightness
      {
         set { Fields["brightness"] = value.ToString(); }
      }

      public bool castShadows
      {
         set { Fields["castShadows"] = value.ToString(); }
      }

      public ColorF color
      {
         set { Fields["color"] = value.ToString(); }
      }

      public float flareScale
      {
         set { Fields["flareScale"] = value.ToString(); }
      }

      public LightFlareData flareType
      {
         set { Fields["flareType"] = value.ToString(); }
      }

      public float range
      {
         set { Fields["range"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator LightDescription(LightDescriptionInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         LightDescription ret = new LightDescription();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(LightDescriptionInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
