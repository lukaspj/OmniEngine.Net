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
   public class GuiDynamicCtrlArrayControlInstance : GuiControlInstance
   {
      public GuiDynamicCtrlArrayControlInstance(string _name = "", string _className = "GuiDynamicCtrlArrayControl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool autoCellSize
      {
         set { Fields["autoCellSize"] = value.ToString(); }
      }

      public int colCount
      {
         set { Fields["colCount"] = value.ToString(); }
      }

      public int colSize
      {
         set { Fields["colSize"] = value.ToString(); }
      }

      public int colSpacing
      {
         set { Fields["colSpacing"] = value.ToString(); }
      }

      public bool dynamicSize
      {
         set { Fields["dynamicSize"] = value.ToString(); }
      }

      public bool fillRowFirst
      {
         set { Fields["fillRowFirst"] = value.ToString(); }
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

      public int rowSize
      {
         set { Fields["rowSize"] = value.ToString(); }
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
      public static implicit operator GuiDynamicCtrlArrayControl(GuiDynamicCtrlArrayControlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiDynamicCtrlArrayControl ret = new GuiDynamicCtrlArrayControl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiDynamicCtrlArrayControlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
