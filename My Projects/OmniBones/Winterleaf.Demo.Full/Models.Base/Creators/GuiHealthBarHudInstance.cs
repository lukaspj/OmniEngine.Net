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
   public class GuiHealthBarHudInstance : GuiControlInstance
   {
      public GuiHealthBarHudInstance(string _name = "", string _className = "GuiHealthBarHud", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public ColorF damageFillColor
      {
         set { Fields["damageFillColor"] = value.ToString(); }
      }

      public bool displayEnergy
      {
         set { Fields["displayEnergy"] = value.ToString(); }
      }

      public ColorF fillColor
      {
         set { Fields["fillColor"] = value.ToString(); }
      }

      public ColorF frameColor
      {
         set { Fields["frameColor"] = value.ToString(); }
      }

      public int pulseRate
      {
         set { Fields["pulseRate"] = value.ToString(); }
      }

      public float pulseThreshold
      {
         set { Fields["pulseThreshold"] = value.ToString(); }
      }

      public bool showFill
      {
         set { Fields["showFill"] = value.ToString(); }
      }

      public bool showFrame
      {
         set { Fields["showFrame"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiHealthBarHud(GuiHealthBarHudInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiHealthBarHud ret = new GuiHealthBarHud();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiHealthBarHudInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
