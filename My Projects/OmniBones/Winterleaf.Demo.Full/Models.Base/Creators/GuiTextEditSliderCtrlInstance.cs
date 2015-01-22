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
   public class GuiTextEditSliderCtrlInstance : GuiTextEditCtrlInstance
   {
      public GuiTextEditSliderCtrlInstance(string _name = "", string _className = "GuiTextEditSliderCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
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
      public static implicit operator GuiTextEditSliderCtrl(GuiTextEditSliderCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiTextEditSliderCtrl ret = new GuiTextEditSliderCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiTextEditSliderCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
