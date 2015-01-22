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
   public class GuiTheoraCtrlInstance : GuiControlInstance
   {
      public GuiTheoraCtrlInstance(string _name = "", string _className = "GuiTheoraCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public ColorI backgroundColor
      {
         set { Fields["backgroundColor"] = value.ToString(); }
      }

      public bool matchVideoSize
      {
         set { Fields["matchVideoSize"] = value.ToString(); }
      }

      public bool playOnWake
      {
         set { Fields["playOnWake"] = value.ToString(); }
      }

      public bool renderDebugInfo
      {
         set { Fields["renderDebugInfo"] = value.ToString(); }
      }

      public bool stopOnSleep
      {
         set { Fields["stopOnSleep"] = value.ToString(); }
      }

      public String theoraFile
      {
         set { Fields["theoraFile"] = value.ToString(); }
      }

      public TypeGuiTheoraTranscoder transcoder
      {
         set { Fields["transcoder"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiTheoraCtrl(GuiTheoraCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiTheoraCtrl ret = new GuiTheoraCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiTheoraCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
