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
   public class PhysicalZoneInstance : SceneObjectInstance
   {
      public PhysicalZoneInstance(string _name = "", string _className = "PhysicalZone", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public Point3F appliedForce
      {
         set { Fields["appliedForce"] = value.ToString(); }
      }

      public float gravityMod
      {
         set { Fields["gravityMod"] = value.ToString(); }
      }

      public Polyhedron polyhedron
      {
         set { Fields["polyhedron"] = value.ToString(); }
      }

      public float velocityMod
      {
         set { Fields["velocityMod"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator PhysicalZone(PhysicalZoneInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         PhysicalZone ret = new PhysicalZone();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(PhysicalZoneInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
