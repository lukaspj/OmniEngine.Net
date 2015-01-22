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
   public class WheeledVehicleDataInstance : VehicleDataInstance
   {
      public WheeledVehicleDataInstance(string _name = "", string _className = "WheeledVehicleData", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float brakeTorque
      {
         set { Fields["brakeTorque"] = value.ToString(); }
      }

      public float engineBrake
      {
         set { Fields["engineBrake"] = value.ToString(); }
      }

      public SFXTrack engineSound
      {
         set { Fields["engineSound"] = value.ToString(); }
      }

      public float engineTorque
      {
         set { Fields["engineTorque"] = value.ToString(); }
      }

      public SFXTrack jetSound
      {
         set { Fields["jetSound"] = value.ToString(); }
      }

      public float maxWheelSpeed
      {
         set { Fields["maxWheelSpeed"] = value.ToString(); }
      }

      public SFXTrack squealSound
      {
         set { Fields["squealSound"] = value.ToString(); }
      }

      public ParticleEmitterData tireEmitter
      {
         set { Fields["tireEmitter"] = value.ToString(); }
      }

      public SFXTrack WheelImpactSound
      {
         set { Fields["WheelImpactSound"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator WheeledVehicleData(WheeledVehicleDataInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         WheeledVehicleData ret = new WheeledVehicleData();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(WheeledVehicleDataInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
