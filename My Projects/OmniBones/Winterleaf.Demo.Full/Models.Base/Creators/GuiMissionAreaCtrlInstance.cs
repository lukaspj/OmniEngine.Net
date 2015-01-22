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
   public class GuiMissionAreaCtrlInstance : GuiBitmapCtrlInstance
   {
      public GuiMissionAreaCtrlInstance(string _name = "", string _className = "GuiMissionAreaCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public ColorI cameraColor
      {
         set { Fields["cameraColor"] = value.ToString(); }
      }

      public String handleBitmap
      {
         set { Fields["handleBitmap"] = value.ToString(); }
      }

      public ColorI missionBoundsColor
      {
         set { Fields["missionBoundsColor"] = value.ToString(); }
      }

      public bool squareBitmap
      {
         set { Fields["squareBitmap"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiMissionAreaCtrl(GuiMissionAreaCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiMissionAreaCtrl ret = new GuiMissionAreaCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiMissionAreaCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
