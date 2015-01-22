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
   public class GuiTabBookCtrlInstance : GuiContainerInstance
   {
      public GuiTabBookCtrlInstance(string _name = "", string _className = "GuiTabBookCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool allowReorder
      {
         set { Fields["allowReorder"] = value.ToString(); }
      }

      public int defaultPage
      {
         set { Fields["defaultPage"] = value.ToString(); }
      }

      public int frontTabPadding
      {
         set { Fields["frontTabPadding"] = value.ToString(); }
      }

      public int minTabWidth
      {
         set { Fields["minTabWidth"] = value.ToString(); }
      }

      public int selectedPage
      {
         set { Fields["selectedPage"] = value.ToString(); }
      }

      public int tabHeight
      {
         set { Fields["tabHeight"] = value.ToString(); }
      }

      public int tabMargin
      {
         set { Fields["tabMargin"] = value.ToString(); }
      }

      public TypeGuiTabPosition tabPosition
      {
         set { Fields["tabPosition"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiTabBookCtrl(GuiTabBookCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiTabBookCtrl ret = new GuiTabBookCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiTabBookCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
