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
   public class GuiChunkedBitmapCtrlInstance : GuiControlInstance
   {
      public GuiChunkedBitmapCtrlInstance(string _name = "", string _className = "GuiChunkedBitmapCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public String bitmap
      {
         set { Fields["bitmap"] = value.ToString(); }
      }

      public bool tile
      {
         set { Fields["tile"] = value.ToString(); }
      }

      public bool useVariable
      {
         set { Fields["useVariable"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiChunkedBitmapCtrl(GuiChunkedBitmapCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiChunkedBitmapCtrl ret = new GuiChunkedBitmapCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiChunkedBitmapCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
