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
   public class GuiScriptNotifyCtrlInstance : GuiControlInstance
   {
      public GuiScriptNotifyCtrlInstance(string _name = "", string _className = "GuiScriptNotifyCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool onChildAddedx
      {
         set { Fields["onChildAdded"] = value.ToString(); }
      }

      public bool onChildRemovedx
      {
         set { Fields["onChildRemoved"] = value.ToString(); }
      }

      public bool onChildResizedx
      {
         set { Fields["onChildResized"] = value.ToString(); }
      }

      public bool onGainFirstResponder
      {
         set { Fields["onGainFirstResponder"] = value.ToString(); }
      }

      public bool onLoseFirstResponder
      {
         set { Fields["onLoseFirstResponder"] = value.ToString(); }
      }

      public bool onParentResizedx
      {
         set { Fields["onParentResized"] = value.ToString(); }
      }

      public bool onResizex
      {
         set { Fields["onResize"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiScriptNotifyCtrl(GuiScriptNotifyCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiScriptNotifyCtrl ret = new GuiScriptNotifyCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiScriptNotifyCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
