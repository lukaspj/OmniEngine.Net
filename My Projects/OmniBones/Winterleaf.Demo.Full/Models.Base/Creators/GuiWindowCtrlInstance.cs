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
   public class GuiWindowCtrlInstance : GuiContainerInstance
   {
      public GuiWindowCtrlInstance(string _name = "", string _className = "GuiWindowCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool AllowPopWindow
      {
         set { Fields["AllowPopWindow"] = value.ToString(); }
      }

      public bool canClose
      {
         set { Fields["canClose"] = value.ToString(); }
      }

      public bool canCollapse
      {
         set { Fields["canCollapse"] = value.ToString(); }
      }

      public bool canMaximize
      {
         set { Fields["canMaximize"] = value.ToString(); }
      }

      public bool canMinimize
      {
         set { Fields["canMinimize"] = value.ToString(); }
      }

      public bool canMove
      {
         set { Fields["canMove"] = value.ToString(); }
      }

      public String closeCommand
      {
         set { Fields["closeCommand"] = value.ToString(); }
      }

      public bool edgeSnap
      {
         set { Fields["edgeSnap"] = value.ToString(); }
      }

      public bool isInPopup
      {
         set { Fields["isInPopup"] = value.ToString(); }
      }

      public bool resizeHeight
      {
         set { Fields["resizeHeight"] = value.ToString(); }
      }

      public bool resizeWidth
      {
         set { Fields["resizeWidth"] = value.ToString(); }
      }

      public bool setTitle
      {
         set { Fields["setTitle"] = value.ToString(); }
      }

      public bool ShowTitle
      {
         set { Fields["ShowTitle"] = value.ToString(); }
      }

      public String text
      {
         set { Fields["text"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiWindowCtrl(GuiWindowCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiWindowCtrl ret = new GuiWindowCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiWindowCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
