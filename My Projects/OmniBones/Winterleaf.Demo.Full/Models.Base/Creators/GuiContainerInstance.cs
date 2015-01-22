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
   public class GuiContainerInstance : GuiControlInstance
   {
      public GuiContainerInstance(string _name = "", string _className = "GuiContainer", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool anchorBottom
      {
         set { Fields["anchorBottom"] = value.ToString(); }
      }

      public bool anchorLeft
      {
         set { Fields["anchorLeft"] = value.ToString(); }
      }

      public bool anchorRight
      {
         set { Fields["anchorRight"] = value.ToString(); }
      }

      public bool anchorTop
      {
         set { Fields["anchorTop"] = value.ToString(); }
      }

      public TypeGuiDockingType docking
      {
         set { Fields["docking"] = value.ToString(); }
      }

      public RectSpacingI margin
      {
         set { Fields["margin"] = value.ToString(); }
      }

      public RectSpacingI padding
      {
         set { Fields["padding"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiContainer(GuiContainerInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiContainer ret = new GuiContainer();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiContainerInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
