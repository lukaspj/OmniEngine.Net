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
   public class GuiTSCtrlInstance : GuiContainerInstance
   {
      public GuiTSCtrlInstance(string _name = "", string _className = "GuiTSCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float cameraRoll
      {
         set { Fields["cameraRoll"] = value.ToString(); }
      }

      public float cameraZRot
      {
         set { Fields["cameraZRot"] = value.ToString(); }
      }

      public bool enableAugmentations
      {
         set { Fields["enableAugmentations"] = value.ToString(); }
      }

      public float forceAspect
      {
         set { Fields["forceAspect"] = value.ToString(); }
      }

      public float forceFOV
      {
         set { Fields["forceFOV"] = value.ToString(); }
      }

      public Point4F forceFrustumOffset
      {
         set { Fields["forceFrustumOffset"] = value.ToString(); }
      }

      public float reflectPriority
      {
         set { Fields["reflectPriority"] = value.ToString(); }
      }

      public TypeGuiTSRenderStyles renderStyle
      {
         set { Fields["renderStyle"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiTSCtrl(GuiTSCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiTSCtrl ret = new GuiTSCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiTSCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
