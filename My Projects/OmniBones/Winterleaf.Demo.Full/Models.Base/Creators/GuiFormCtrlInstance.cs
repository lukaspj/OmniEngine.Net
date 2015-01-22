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
   public class GuiFormCtrlInstance : GuiPanelInstance
   {
      public GuiFormCtrlInstance(string _name = "", string _className = "GuiFormCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public String caption
      {
         set { Fields["caption"] = value.ToString(); }
      }

      public String content
      {
         set { Fields["content"] = value.ToString(); }
      }

      public String contentLibrary
      {
         set { Fields["contentLibrary"] = value.ToString(); }
      }

      public bool hasMenu
      {
         set { Fields["hasMenu"] = value.ToString(); }
      }

      public bool movable
      {
         set { Fields["movable"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiFormCtrl(GuiFormCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiFormCtrl ret = new GuiFormCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiFormCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
