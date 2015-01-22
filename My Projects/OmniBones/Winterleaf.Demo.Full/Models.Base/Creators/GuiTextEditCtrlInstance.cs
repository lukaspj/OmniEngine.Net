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
   public class GuiTextEditCtrlInstance : GuiTextCtrlInstance
   {
      public GuiTextEditCtrlInstance(string _name = "", string _className = "GuiTextEditCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public TypeSFXTrackName deniedSound
      {
         set { Fields["deniedSound"] = value.ToString(); }
      }

      public String escapeCommand
      {
         set { Fields["escapeCommand"] = value.ToString(); }
      }

      public int historySize
      {
         set { Fields["historySize"] = value.ToString(); }
      }

      public bool password
      {
         set { Fields["password"] = value.ToString(); }
      }

      public String passwordMask
      {
         set { Fields["passwordMask"] = value.ToString(); }
      }

      public bool sinkAllKeyEvents
      {
         set { Fields["sinkAllKeyEvents"] = value.ToString(); }
      }

      public bool tabComplete
      {
         set { Fields["tabComplete"] = value.ToString(); }
      }

      public String validate
      {
         set { Fields["validate"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiTextEditCtrl(GuiTextEditCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiTextEditCtrl ret = new GuiTextEditCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiTextEditCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
