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
   public class GuiSeparatorCtrlInstance : GuiControlInstance
   {
      public GuiSeparatorCtrlInstance(string _name = "", string _className = "GuiSeparatorCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public int borderMargin
      {
         set { Fields["borderMargin"] = value.ToString(); }
      }

      public String caption
      {
         set { Fields["caption"] = value.ToString(); }
      }

      public bool invisible
      {
         set { Fields["invisible"] = value.ToString(); }
      }

      public int leftMargin
      {
         set { Fields["leftMargin"] = value.ToString(); }
      }

      public TypeGuiSeparatorType type
      {
         set { Fields["type"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiSeparatorCtrl(GuiSeparatorCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiSeparatorCtrl ret = new GuiSeparatorCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiSeparatorCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
