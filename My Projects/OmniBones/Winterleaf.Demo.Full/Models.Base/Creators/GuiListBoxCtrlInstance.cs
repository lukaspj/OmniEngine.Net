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
   public class GuiListBoxCtrlInstance : GuiControlInstance
   {
      public GuiListBoxCtrlInstance(string _name = "", string _className = "GuiListBoxCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool allowMultipleSelections
      {
         set { Fields["allowMultipleSelections"] = value.ToString(); }
      }

      public bool colorBullet
      {
         set { Fields["colorBullet"] = value.ToString(); }
      }

      public bool fitParentWidth
      {
         set { Fields["fitParentWidth"] = value.ToString(); }
      }

      public String makeNameCallback
      {
         set { Fields["makeNameCallback"] = value.ToString(); }
      }

      public String mirrorSet
      {
         set { Fields["mirrorSet"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiListBoxCtrl(GuiListBoxCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiListBoxCtrl ret = new GuiListBoxCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiListBoxCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
