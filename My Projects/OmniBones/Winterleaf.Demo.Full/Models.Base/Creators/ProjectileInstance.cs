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
   public class ProjectileInstance : GameBaseInstance
   {
      public ProjectileInstance(string _name = "", string _className = "Projectile", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public Point3F initialPosition
      {
         set { Fields["initialPosition"] = value.ToString(); }
      }

      public Point3F initialVelocity
      {
         set { Fields["initialVelocity"] = value.ToString(); }
      }

      public int sourceObject
      {
         set { Fields["sourceObject"] = value.ToString(); }
      }

      public int sourceSlot
      {
         set { Fields["sourceSlot"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator Projectile(ProjectileInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         Projectile ret = new Projectile();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(ProjectileInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
