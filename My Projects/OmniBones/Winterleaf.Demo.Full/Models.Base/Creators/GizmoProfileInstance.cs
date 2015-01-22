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
   public class GizmoProfileInstance : SimObjectInstance
   {
      public GizmoProfileInstance(string _name = "", string _className = "GizmoProfile", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public TypeGizmoAlignment alignment
      {
         set { Fields["alignment"] = value.ToString(); }
      }

      public bool allowSnapRotations
      {
         set { Fields["allowSnapRotations"] = value.ToString(); }
      }

      public bool allowSnapScale
      {
         set { Fields["allowSnapScale"] = value.ToString(); }
      }

      public int flags
      {
         set { Fields["flags"] = value.ToString(); }
      }

      public ColorI gridColor
      {
         set { Fields["gridColor"] = value.ToString(); }
      }

      public Point3F gridSize
      {
         set { Fields["gridSize"] = value.ToString(); }
      }

      public TypeGizmoMode mode
      {
         set { Fields["mode"] = value.ToString(); }
      }

      public float planeDim
      {
         set { Fields["planeDim"] = value.ToString(); }
      }

      public bool renderInfoText
      {
         set { Fields["renderInfoText"] = value.ToString(); }
      }

      public bool renderMoveGrid
      {
         set { Fields["renderMoveGrid"] = value.ToString(); }
      }

      public bool renderPlane
      {
         set { Fields["renderPlane"] = value.ToString(); }
      }

      public bool renderPlaneHashes
      {
         set { Fields["renderPlaneHashes"] = value.ToString(); }
      }

      public bool renderSolid
      {
         set { Fields["renderSolid"] = value.ToString(); }
      }

      public bool renderWhenUsed
      {
         set { Fields["renderWhenUsed"] = value.ToString(); }
      }

      public float rotateScalar
      {
         set { Fields["rotateScalar"] = value.ToString(); }
      }

      public float rotationSnap
      {
         set { Fields["rotationSnap"] = value.ToString(); }
      }

      public float scaleScalar
      {
         set { Fields["scaleScalar"] = value.ToString(); }
      }

      public float scaleSnap
      {
         set { Fields["scaleSnap"] = value.ToString(); }
      }

      public int screenLength
      {
         set { Fields["screenLength"] = value.ToString(); }
      }

      public bool snapToGrid
      {
         set { Fields["snapToGrid"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GizmoProfile(GizmoProfileInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GizmoProfile ret = new GizmoProfile();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GizmoProfileInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
