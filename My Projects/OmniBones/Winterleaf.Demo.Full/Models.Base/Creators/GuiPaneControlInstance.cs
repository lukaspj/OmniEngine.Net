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
   public class GuiPaneControlInstance : GuiControlInstance
   {
      public GuiPaneControlInstance(string _name = "", string _className = "GuiPaneControl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool barBehindText
      {
         set { Fields["barBehindText"] = value.ToString(); }
      }

      public String caption
      {
         set { Fields["caption"] = value.ToString(); }
      }

      public String captionID
      {
         set { Fields["captionID"] = value.ToString(); }
      }

      public bool collapsable
      {
         set { Fields["collapsable"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiPaneControl(GuiPaneControlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiPaneControl ret = new GuiPaneControl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiPaneControlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
