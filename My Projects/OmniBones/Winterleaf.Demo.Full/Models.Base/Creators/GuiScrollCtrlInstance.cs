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
   public class GuiScrollCtrlInstance : GuiContainerInstance
   {
      public GuiScrollCtrlInstance(string _name = "", string _className = "GuiScrollCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public Point2I childMargin
      {
         set { Fields["childMargin"] = value.ToString(); }
      }

      public bool constantThumbHeight
      {
         set { Fields["constantThumbHeight"] = value.ToString(); }
      }

      public TypeGuiScrollBarBehavior hScrollBar
      {
         set { Fields["hScrollBar"] = value.ToString(); }
      }

      public bool lockHorizScroll
      {
         set { Fields["lockHorizScroll"] = value.ToString(); }
      }

      public bool lockVertScroll
      {
         set { Fields["lockVertScroll"] = value.ToString(); }
      }

      public int mouseWheelScrollSpeed
      {
         set { Fields["mouseWheelScrollSpeed"] = value.ToString(); }
      }

      public TypeGuiScrollBarBehavior vScrollBar
      {
         set { Fields["vScrollBar"] = value.ToString(); }
      }

      public bool willFirstRespond
      {
         set { Fields["willFirstRespond"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiScrollCtrl(GuiScrollCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiScrollCtrl ret = new GuiScrollCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiScrollCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
