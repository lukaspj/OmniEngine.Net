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
   public class GroundPlaneInstance : SceneObjectInstance
   {
      public GroundPlaneInstance(string _name = "", string _className = "GroundPlane", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public TypeMaterialName material
      {
         set { Fields["material"] = value.ToString(); }
      }

      public float scaleU
      {
         set { Fields["scaleU"] = value.ToString(); }
      }

      public float scaleV
      {
         set { Fields["scaleV"] = value.ToString(); }
      }

      public float squareSize
      {
         set { Fields["squareSize"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GroundPlane(GroundPlaneInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GroundPlane ret = new GroundPlane();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GroundPlaneInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
