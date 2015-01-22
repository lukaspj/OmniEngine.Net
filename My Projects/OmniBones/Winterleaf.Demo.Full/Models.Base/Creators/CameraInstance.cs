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
   public class CameraInstance : ShapeBaseInstance
   {
      public CameraInstance(string _name = "", string _className = "Camera", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float angularDrag
      {
         set { Fields["angularDrag"] = value.ToString(); }
      }

      public float angularForce
      {
         set { Fields["angularForce"] = value.ToString(); }
      }

      public float brakeMultiplier
      {
         set { Fields["brakeMultiplier"] = value.ToString(); }
      }

      public TypeCameraMotionMode controlMode
      {
         set { Fields["controlMode"] = value.ToString(); }
      }

      public float drag
      {
         set { Fields["drag"] = value.ToString(); }
      }

      public float force
      {
         set { Fields["force"] = value.ToString(); }
      }

      public float mass
      {
         set { Fields["mass"] = value.ToString(); }
      }

      public bool newtonMode
      {
         set { Fields["newtonMode"] = value.ToString(); }
      }

      public bool newtonRotation
      {
         set { Fields["newtonRotation"] = value.ToString(); }
      }

      public float speedMultiplier
      {
         set { Fields["speedMultiplier"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator Camera(CameraInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         Camera ret = new Camera();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(CameraInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
