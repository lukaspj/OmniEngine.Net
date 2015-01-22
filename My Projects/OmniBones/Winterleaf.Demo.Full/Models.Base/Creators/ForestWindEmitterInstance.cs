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
   public class ForestWindEmitterInstance : SceneObjectInstance
   {
      public ForestWindEmitterInstance(string _name = "", string _className = "ForestWindEmitter", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float gustFrequency
      {
         set { Fields["gustFrequency"] = value.ToString(); }
      }

      public float gustStrength
      {
         set { Fields["gustStrength"] = value.ToString(); }
      }

      public float gustWobbleStrength
      {
         set { Fields["gustWobbleStrength"] = value.ToString(); }
      }

      public float gustYawAngle
      {
         set { Fields["gustYawAngle"] = value.ToString(); }
      }

      public float gustYawFrequency
      {
         set { Fields["gustYawFrequency"] = value.ToString(); }
      }

      public bool hasMount
      {
         set { Fields["hasMount"] = value.ToString(); }
      }

      public bool radialEmitter
      {
         set { Fields["radialEmitter"] = value.ToString(); }
      }

      public float radius
      {
         set { Fields["radius"] = value.ToString(); }
      }

      public float strength
      {
         set { Fields["strength"] = value.ToString(); }
      }

      public float turbulenceFrequency
      {
         set { Fields["turbulenceFrequency"] = value.ToString(); }
      }

      public float turbulenceStrength
      {
         set { Fields["turbulenceStrength"] = value.ToString(); }
      }

      public bool windEnabled
      {
         set { Fields["windEnabled"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator ForestWindEmitter(ForestWindEmitterInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         ForestWindEmitter ret = new ForestWindEmitter();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(ForestWindEmitterInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
