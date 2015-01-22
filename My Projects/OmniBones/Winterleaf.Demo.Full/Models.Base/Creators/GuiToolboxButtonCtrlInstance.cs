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
   public class GuiToolboxButtonCtrlInstance : GuiButtonCtrlInstance
   {
      public GuiToolboxButtonCtrlInstance(string _name = "", string _className = "GuiToolboxButtonCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public String hoverBitmap
      {
         set { Fields["hoverBitmap"] = value.ToString(); }
      }

      public String loweredBitmap
      {
         set { Fields["loweredBitmap"] = value.ToString(); }
      }

      public String normalBitmap
      {
         set { Fields["normalBitmap"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiToolboxButtonCtrl(GuiToolboxButtonCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiToolboxButtonCtrl ret = new GuiToolboxButtonCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiToolboxButtonCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
