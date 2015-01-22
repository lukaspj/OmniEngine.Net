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
   public class GuiFlexibleArrayControlInstance : GuiControlInstance
   {
      public GuiFlexibleArrayControlInstance(string _name = "", string _className = "GuiFlexibleArrayControl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public int colSpacing
      {
         set { Fields["colSpacing"] = value.ToString(); }
      }

      public bool frozen
      {
         set { Fields["frozen"] = value.ToString(); }
      }

      public RectSpacingI padding
      {
         set { Fields["padding"] = value.ToString(); }
      }

      public int rowCount
      {
         set { Fields["rowCount"] = value.ToString(); }
      }

      public int rowSpacing
      {
         set { Fields["rowSpacing"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiFlexibleArrayControl(GuiFlexibleArrayControlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiFlexibleArrayControl ret = new GuiFlexibleArrayControl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiFlexibleArrayControlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
