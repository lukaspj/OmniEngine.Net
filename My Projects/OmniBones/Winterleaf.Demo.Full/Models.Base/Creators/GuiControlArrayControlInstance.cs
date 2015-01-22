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
   public class GuiControlArrayControlInstance : GuiControlInstance
   {
      public GuiControlArrayControlInstance(string _name = "", string _className = "GuiControlArrayControl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public int colCount
      {
         set { Fields["colCount"] = value.ToString(); }
      }

      public VectorInt colSizes
      {
         set { Fields["colSizes"] = value.ToString(); }
      }

      public int colSpacing
      {
         set { Fields["colSpacing"] = value.ToString(); }
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
      public static implicit operator GuiControlArrayControl(GuiControlArrayControlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiControlArrayControl ret = new GuiControlArrayControl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiControlArrayControlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
