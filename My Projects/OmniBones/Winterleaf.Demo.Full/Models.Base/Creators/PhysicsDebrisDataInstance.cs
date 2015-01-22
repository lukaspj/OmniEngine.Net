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
   public class PhysicsDebrisDataInstance : GameBaseDataInstance
   {
      public PhysicsDebrisDataInstance(string _name = "", string _className = "PhysicsDebrisData", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float angularDamping
      {
         set { Fields["angularDamping"] = value.ToString(); }
      }

      public float angularSleepThreshold
      {
         set { Fields["angularSleepThreshold"] = value.ToString(); }
      }

      public float buoyancyDensity
      {
         set { Fields["buoyancyDensity"] = value.ToString(); }
      }

      public bool castShadows
      {
         set { Fields["castShadows"] = value.ToString(); }
      }

      public float friction
      {
         set { Fields["friction"] = value.ToString(); }
      }

      public float lifetime
      {
         set { Fields["lifetime"] = value.ToString(); }
      }

      public float lifetimeVariance
      {
         set { Fields["lifetimeVariance"] = value.ToString(); }
      }

      public float linearDamping
      {
         set { Fields["linearDamping"] = value.ToString(); }
      }

      public float linearSleepThreshold
      {
         set { Fields["linearSleepThreshold"] = value.ToString(); }
      }

      public float mass
      {
         set { Fields["mass"] = value.ToString(); }
      }

      public float restitution
      {
         set { Fields["restitution"] = value.ToString(); }
      }

      public TypeShapeFilename shapeFile
      {
         set { Fields["shapeFile"] = value.ToString(); }
      }

      public float staticFriction
      {
         set { Fields["staticFriction"] = value.ToString(); }
      }

      public float waterDampingScale
      {
         set { Fields["waterDampingScale"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator PhysicsDebrisData(PhysicsDebrisDataInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         PhysicsDebrisData ret = new PhysicsDebrisData();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(PhysicsDebrisDataInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
