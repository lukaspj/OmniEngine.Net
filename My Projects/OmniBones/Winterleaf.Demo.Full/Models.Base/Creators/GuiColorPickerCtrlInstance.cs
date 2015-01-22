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
   public class GuiColorPickerCtrlInstance : GuiControlInstance
   {
      public GuiColorPickerCtrlInstance(string _name = "", string _className = "GuiColorPickerCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool actionOnMove
      {
         set { Fields["actionOnMove"] = value.ToString(); }
      }

      public ColorF baseColor
      {
         set { Fields["baseColor"] = value.ToString(); }
      }

      public TypeGuiColorPickMode displayMode
      {
         set { Fields["displayMode"] = value.ToString(); }
      }

      public ColorF pickColor
      {
         set { Fields["pickColor"] = value.ToString(); }
      }

      public int selectorGap
      {
         set { Fields["selectorGap"] = value.ToString(); }
      }

      public bool showReticle
      {
         set { Fields["showReticle"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiColorPickerCtrl(GuiColorPickerCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiColorPickerCtrl ret = new GuiColorPickerCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiColorPickerCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
