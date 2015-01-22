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
   public class WheeledVehicleSpringInstance : SimDataBlockInstance
   {
      public WheeledVehicleSpringInstance(string _name = "", string _className = "WheeledVehicleSpring", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float antiSwayForce
      {
         set { Fields["antiSwayForce"] = value.ToString(); }
      }

      public float damping
      {
         set { Fields["damping"] = value.ToString(); }
      }

      public float force
      {
         set { Fields["force"] = value.ToString(); }
      }

      public float length
      {
         set { Fields["length"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator WheeledVehicleSpring(WheeledVehicleSpringInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         WheeledVehicleSpring ret = new WheeledVehicleSpring();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(WheeledVehicleSpringInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
