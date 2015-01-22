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
   public class GuiObjectViewInstance : GuiTSCtrlInstance
   {
      public GuiObjectViewInstance(string _name = "", string _className = "GuiObjectView", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public String animSequence
      {
         set { Fields["animSequence"] = value.ToString(); }
      }

      public Point3F cameraRotation
      {
         set { Fields["cameraRotation"] = value.ToString(); }
      }

      public float cameraSpeed
      {
         set { Fields["cameraSpeed"] = value.ToString(); }
      }

      public ColorF lightAmbient
      {
         set { Fields["lightAmbient"] = value.ToString(); }
      }

      public ColorF lightColor
      {
         set { Fields["lightColor"] = value.ToString(); }
      }

      public Point3F lightDirection
      {
         set { Fields["lightDirection"] = value.ToString(); }
      }

      public float maxOrbitDiststance
      {
         set { Fields["maxOrbitDiststance"] = value.ToString(); }
      }

      public float minOrbitDiststance
      {
         set { Fields["minOrbitDiststance"] = value.ToString(); }
      }

      public String mountedNode
      {
         set { Fields["mountedNode"] = value.ToString(); }
      }

      public String mountedShapeFile
      {
         set { Fields["mountedShapeFile"] = value.ToString(); }
      }

      public String mountedSkin
      {
         set { Fields["mountedSkin"] = value.ToString(); }
      }

      public float orbitDiststance
      {
         set { Fields["orbitDiststance"] = value.ToString(); }
      }

      public String shapeFile
      {
         set { Fields["shapeFile"] = value.ToString(); }
      }

      public String skin
      {
         set { Fields["skin"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiObjectView(GuiObjectViewInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiObjectView ret = new GuiObjectView();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiObjectViewInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
