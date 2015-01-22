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
   public class GuiGameListMenuCtrlInstance : GuiControlInstance
   {
      public GuiGameListMenuCtrlInstance(string _name = "", string _className = "GuiGameListMenuCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public String callbackOnA
      {
         set { Fields["callbackOnA"] = value.ToString(); }
      }

      public String callbackOnB
      {
         set { Fields["callbackOnB"] = value.ToString(); }
      }

      public String callbackOnX
      {
         set { Fields["callbackOnX"] = value.ToString(); }
      }

      public String callbackOnY
      {
         set { Fields["callbackOnY"] = value.ToString(); }
      }

      public bool debugRender
      {
         set { Fields["debugRender"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiGameListMenuCtrl(GuiGameListMenuCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiGameListMenuCtrl ret = new GuiGameListMenuCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiGameListMenuCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
