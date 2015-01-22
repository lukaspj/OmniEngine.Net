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
   public class WheeledVehicleTireInstance : SimDataBlockInstance
   {
      public WheeledVehicleTireInstance(string _name = "", string _className = "WheeledVehicleTire", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float kineticFriction
      {
         set { Fields["kineticFriction"] = value.ToString(); }
      }

      public float lateralDamping
      {
         set { Fields["lateralDamping"] = value.ToString(); }
      }

      public float lateralForce
      {
         set { Fields["lateralForce"] = value.ToString(); }
      }

      public float lateralRelaxation
      {
         set { Fields["lateralRelaxation"] = value.ToString(); }
      }

      public float longitudinalDamping
      {
         set { Fields["longitudinalDamping"] = value.ToString(); }
      }

      public float longitudinalForce
      {
         set { Fields["longitudinalForce"] = value.ToString(); }
      }

      public float longitudinalRelaxation
      {
         set { Fields["longitudinalRelaxation"] = value.ToString(); }
      }

      public float mass
      {
         set { Fields["mass"] = value.ToString(); }
      }

      public float radius
      {
         set { Fields["radius"] = value.ToString(); }
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

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator WheeledVehicleTire(WheeledVehicleTireInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         WheeledVehicleTire ret = new WheeledVehicleTire();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(WheeledVehicleTireInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
