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
   public class GuiRolloutCtrlInstance : GuiControlInstance
   {
      public GuiRolloutCtrlInstance(string _name = "", string _className = "GuiRolloutCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool autoCollapseSiblings
      {
         set { Fields["autoCollapseSiblings"] = value.ToString(); }
      }

      public String caption
      {
         set { Fields["caption"] = value.ToString(); }
      }

      public bool clickCollapse
      {
         set { Fields["clickCollapse"] = value.ToString(); }
      }

      public int defaultHeight
      {
         set { Fields["defaultHeight"] = value.ToString(); }
      }

      public bool expanded
      {
         set { Fields["expanded"] = value.ToString(); }
      }

      public bool hideHeader
      {
         set { Fields["hideHeader"] = value.ToString(); }
      }

      public RectI margin
      {
         set { Fields["margin"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiRolloutCtrl(GuiRolloutCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiRolloutCtrl ret = new GuiRolloutCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiRolloutCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
