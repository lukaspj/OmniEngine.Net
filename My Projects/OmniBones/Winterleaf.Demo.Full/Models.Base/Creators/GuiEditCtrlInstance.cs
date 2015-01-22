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
   public class GuiEditCtrlInstance : GuiControlInstance
   {
      public GuiEditCtrlInstance(string _name = "", string _className = "GuiEditCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool drawBorderLines
      {
         set { Fields["drawBorderLines"] = value.ToString(); }
      }

      public bool drawGuides
      {
         set { Fields["drawGuides"] = value.ToString(); }
      }

      public bool fullBoxSelection
      {
         set { Fields["fullBoxSelection"] = value.ToString(); }
      }

      public int snapSensitivity
      {
         set { Fields["snapSensitivity"] = value.ToString(); }
      }

      public bool snapToCanvas
      {
         set { Fields["snapToCanvas"] = value.ToString(); }
      }

      public bool snapToCenters
      {
         set { Fields["snapToCenters"] = value.ToString(); }
      }

      public bool snapToControls
      {
         set { Fields["snapToControls"] = value.ToString(); }
      }

      public bool snapToEdges
      {
         set { Fields["snapToEdges"] = value.ToString(); }
      }

      public bool snapToGuides
      {
         set { Fields["snapToGuides"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiEditCtrl(GuiEditCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiEditCtrl ret = new GuiEditCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiEditCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
