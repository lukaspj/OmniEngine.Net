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
   public class LightBaseInstance : SceneObjectInstance
   {
      public LightBaseInstance(string _name = "", string _className = "LightBase", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool animate
      {
         set { Fields["animate"] = value.ToString(); }
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

      public bool isEnabled
      {
         set { Fields["isEnabled"] = value.ToString(); }
      }

      public float priority
      {
         set { Fields["priority"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator LightBase(LightBaseInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         LightBase ret = new LightBase();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(LightBaseInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
