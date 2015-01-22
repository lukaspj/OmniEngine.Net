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
   public class FlyingVehicleDataInstance : VehicleDataInstance
   {
      public FlyingVehicleDataInstance(string _name = "", string _className = "FlyingVehicleData", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float autoAngularForce
      {
         set { Fields["autoAngularForce"] = value.ToString(); }
      }

      public float autoInputDamping
      {
         set { Fields["autoInputDamping"] = value.ToString(); }
      }

      public float autoLinearForce
      {
         set { Fields["autoLinearForce"] = value.ToString(); }
      }

      public ParticleEmitterData backwardJetEmitter
      {
         set { Fields["backwardJetEmitter"] = value.ToString(); }
      }

      public float createHoverHeight
      {
         set { Fields["createHoverHeight"] = value.ToString(); }
      }

      public ParticleEmitterData downJetEmitter
      {
         set { Fields["downJetEmitter"] = value.ToString(); }
      }

      public SFXProfile engineSound
      {
         set { Fields["engineSound"] = value.ToString(); }
      }

      public ParticleEmitterData forwardJetEmitter
      {
         set { Fields["forwardJetEmitter"] = value.ToString(); }
      }

      public float horizontalSurfaceForce
      {
         set { Fields["horizontalSurfaceForce"] = value.ToString(); }
      }

      public float hoverHeight
      {
         set { Fields["hoverHeight"] = value.ToString(); }
      }

      public SFXProfile jetSound
      {
         set { Fields["jetSound"] = value.ToString(); }
      }

      public float maneuveringForce
      {
         set { Fields["maneuveringForce"] = value.ToString(); }
      }

      public float maxAutoSpeed
      {
         set { Fields["maxAutoSpeed"] = value.ToString(); }
      }

      public float minTrailSpeed
      {
         set { Fields["minTrailSpeed"] = value.ToString(); }
      }

      public float rollForce
      {
         set { Fields["rollForce"] = value.ToString(); }
      }

      public float rotationalDrag
      {
         set { Fields["rotationalDrag"] = value.ToString(); }
      }

      public float steeringForce
      {
         set { Fields["steeringForce"] = value.ToString(); }
      }

      public float steeringRollForce
      {
         set { Fields["steeringRollForce"] = value.ToString(); }
      }

      public ParticleEmitterData trailEmitter
      {
         set { Fields["trailEmitter"] = value.ToString(); }
      }

      public float verticalSurfaceForce
      {
         set { Fields["verticalSurfaceForce"] = value.ToString(); }
      }

      public float vertThrustMultiple
      {
         set { Fields["vertThrustMultiple"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator FlyingVehicleData(FlyingVehicleDataInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         FlyingVehicleData ret = new FlyingVehicleData();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(FlyingVehicleDataInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
