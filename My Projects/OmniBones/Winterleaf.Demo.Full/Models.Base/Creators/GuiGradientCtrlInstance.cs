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
   public class GuiGradientCtrlInstance : GuiControlInstance
   {
      public GuiGradientCtrlInstance(string _name = "", string _className = "GuiGradientCtrl", ObjectType pObjectType = ObjectType.Instance)
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

      public TypeGuiGradientPickMode displayMode
      {
         set { Fields["displayMode"] = value.ToString(); }
      }

      public ColorF pickColor
      {
         set { Fields["pickColor"] = value.ToString(); }
      }

      public bool showReticle
      {
         set { Fields["showReticle"] = value.ToString(); }
      }

      public int swatchFactor
      {
         set { Fields["swatchFactor"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiGradientCtrl(GuiGradientCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiGradientCtrl ret = new GuiGradientCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiGradientCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
