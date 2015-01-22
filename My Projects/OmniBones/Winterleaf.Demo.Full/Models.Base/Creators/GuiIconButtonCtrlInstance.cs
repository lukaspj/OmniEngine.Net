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
   public class GuiIconButtonCtrlInstance : GuiButtonCtrlInstance
   {
      public GuiIconButtonCtrlInstance(string _name = "", string _className = "GuiIconButtonCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool autoSize
      {
         set { Fields["autoSize"] = value.ToString(); }
      }

      public Point2I buttonMargin
      {
         set { Fields["buttonMargin"] = value.ToString(); }
      }

      public String iconBitmap
      {
         set { Fields["iconBitmap"] = value.ToString(); }
      }

      public TypeGuiIconButtonIconLocation iconLocation
      {
         set { Fields["iconLocation"] = value.ToString(); }
      }

      public bool makeIconSquare
      {
         set { Fields["makeIconSquare"] = value.ToString(); }
      }

      public bool sizeIconToButton
      {
         set { Fields["sizeIconToButton"] = value.ToString(); }
      }

      public TypeGuiIconButtonTextLocation textLocation
      {
         set { Fields["textLocation"] = value.ToString(); }
      }

      public int textMargin
      {
         set { Fields["textMargin"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiIconButtonCtrl(GuiIconButtonCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiIconButtonCtrl ret = new GuiIconButtonCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiIconButtonCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
