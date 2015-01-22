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
   public class GuiTextEditSliderBitmapCtrlInstance : GuiTextEditCtrlInstance
   {
      public GuiTextEditSliderBitmapCtrlInstance(string _name = "", string _className = "GuiTextEditSliderBitmapCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public String bitmap
      {
         set { Fields["bitmap"] = value.ToString(); }
      }

      public bool focusOnMouseWheel
      {
         set { Fields["focusOnMouseWheel"] = value.ToString(); }
      }

      public String format
      {
         set { Fields["format"] = value.ToString(); }
      }

      public float increment
      {
         set { Fields["increment"] = value.ToString(); }
      }

      public Point2F range
      {
         set { Fields["range"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiTextEditSliderBitmapCtrl(GuiTextEditSliderBitmapCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiTextEditSliderBitmapCtrl ret = new GuiTextEditSliderBitmapCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiTextEditSliderBitmapCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
