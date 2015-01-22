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
   public class VehicleInstance : ShapeBaseInstance
   {
      public VehicleInstance(string _name = "", string _className = "Vehicle", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool disableMove
      {
         set { Fields["disableMove"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator Vehicle(VehicleInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         Vehicle ret = new Vehicle();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(VehicleInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
