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
   public class GuiEaseViewCtrlInstance : GuiControlInstance
   {
      public GuiEaseViewCtrlInstance(string _name = "", string _className = "GuiEaseViewCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public ColorF axisColor
      {
         set { Fields["axisColor"] = value.ToString(); }
      }

      public EaseF ease
      {
         set { Fields["ease"] = value.ToString(); }
      }

      public ColorF easeColor
      {
         set { Fields["easeColor"] = value.ToString(); }
      }

      public float easeWidth
      {
         set { Fields["easeWidth"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiEaseViewCtrl(GuiEaseViewCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiEaseViewCtrl ret = new GuiEaseViewCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiEaseViewCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
