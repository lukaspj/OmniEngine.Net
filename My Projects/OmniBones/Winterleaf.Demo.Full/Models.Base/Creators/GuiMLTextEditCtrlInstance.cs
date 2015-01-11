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
   public class GuiMLTextEditCtrlInstance : GuiMLTextCtrlInstance
   {
      public GuiMLTextEditCtrlInstance(string _name = "", string _className = "GuiMLTextEditCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public String escapeCommand
      {
         set { Fields["escapeCommand"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiMLTextEditCtrl(GuiMLTextEditCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiMLTextEditCtrl ret = new GuiMLTextEditCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiMLTextEditCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}