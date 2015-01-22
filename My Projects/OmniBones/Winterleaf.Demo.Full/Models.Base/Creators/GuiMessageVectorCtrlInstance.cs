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
   public class GuiMessageVectorCtrlInstance : GuiControlInstance
   {
      public GuiMessageVectorCtrlInstance(string _name = "", string _className = "GuiMessageVectorCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public int lineContinuedIndex
      {
         set { Fields["lineContinuedIndex"] = value.ToString(); }
      }

      public int lineSpacing
      {
         set { Fields["lineSpacing"] = value.ToString(); }
      }

      public ColorI matchColor
      {
         set { Fields["matchColor"] = value.ToString(); }
      }

      public int maxColorIndex
      {
         set { Fields["maxColorIndex"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiMessageVectorCtrl(GuiMessageVectorCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiMessageVectorCtrl ret = new GuiMessageVectorCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiMessageVectorCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
