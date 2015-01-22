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
   public class GuiFrameSetCtrlInstance : GuiContainerInstance
   {
      public GuiFrameSetCtrlInstance(string _name = "", string _className = "GuiFrameSetCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool autoBalance
      {
         set { Fields["autoBalance"] = value.ToString(); }
      }

      public ColorI borderColor
      {
         set { Fields["borderColor"] = value.ToString(); }
      }

      public TypeGuiFrameState borderEnable
      {
         set { Fields["borderEnable"] = value.ToString(); }
      }

      public TypeGuiFrameState borderMovable
      {
         set { Fields["borderMovable"] = value.ToString(); }
      }

      public int borderWidth
      {
         set { Fields["borderWidth"] = value.ToString(); }
      }

      public VectorInt columns
      {
         set { Fields["columns"] = value.ToString(); }
      }

      public int fudgeFactor
      {
         set { Fields["fudgeFactor"] = value.ToString(); }
      }

      public VectorInt rows
      {
         set { Fields["rows"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiFrameSetCtrl(GuiFrameSetCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiFrameSetCtrl ret = new GuiFrameSetCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiFrameSetCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
