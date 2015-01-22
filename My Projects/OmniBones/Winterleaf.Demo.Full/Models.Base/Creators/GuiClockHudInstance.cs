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
   public class GuiClockHudInstance : GuiControlInstance
   {
      public GuiClockHudInstance(string _name = "", string _className = "GuiClockHud", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public ColorF fillColor
      {
         set { Fields["fillColor"] = value.ToString(); }
      }

      public ColorF frameColor
      {
         set { Fields["frameColor"] = value.ToString(); }
      }

      public bool showFill
      {
         set { Fields["showFill"] = value.ToString(); }
      }

      public bool showFrame
      {
         set { Fields["showFrame"] = value.ToString(); }
      }

      public ColorF textColor
      {
         set { Fields["textColor"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiClockHud(GuiClockHudInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiClockHud ret = new GuiClockHud();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiClockHudInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
