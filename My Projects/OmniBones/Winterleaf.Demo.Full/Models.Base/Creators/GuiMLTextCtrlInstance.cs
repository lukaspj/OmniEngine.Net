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
   public class GuiMLTextCtrlInstance : GuiControlInstance
   {
      public GuiMLTextCtrlInstance(string _name = "", string _className = "GuiMLTextCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool allowColorChars
      {
         set { Fields["allowColorChars"] = value.ToString(); }
      }

      public TypeSFXTrackName deniedSound
      {
         set { Fields["deniedSound"] = value.ToString(); }
      }

      public int lineSpacing
      {
         set { Fields["lineSpacing"] = value.ToString(); }
      }

      public int maxChars
      {
         set { Fields["maxChars"] = value.ToString(); }
      }

      public String text
      {
         set { Fields["text"] = value.ToString(); }
      }

      public bool useURLMouseCursor
      {
         set { Fields["useURLMouseCursor"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiMLTextCtrl(GuiMLTextCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiMLTextCtrl ret = new GuiMLTextCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiMLTextCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
