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
   public class WalkableShapeInstance : TSDynamicInstance
   {
      public WalkableShapeInstance(string _name = "", string _className = "WalkableShape", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float RayLength
      {
         set { Fields["RayLength"] = value.ToString(); }
      }

      public bool UseAutoAttach
      {
         set { Fields["UseAutoAttach"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator WalkableShape(WalkableShapeInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         WalkableShape ret = new WalkableShape();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(WalkableShapeInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
