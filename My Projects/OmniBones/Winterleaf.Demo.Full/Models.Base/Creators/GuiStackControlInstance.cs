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
   public class GuiStackControlInstance : GuiControlInstance
   {
      public GuiStackControlInstance(string _name = "", string _className = "GuiStackControl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool changeChildPosition
      {
         set { Fields["changeChildPosition"] = value.ToString(); }
      }

      public bool changeChildSizeToFit
      {
         set { Fields["changeChildSizeToFit"] = value.ToString(); }
      }

      public bool dynamicNonStackExtent
      {
         set { Fields["dynamicNonStackExtent"] = value.ToString(); }
      }

      public bool dynamicPos
      {
         set { Fields["dynamicPos"] = value.ToString(); }
      }

      public bool dynamicSize
      {
         set { Fields["dynamicSize"] = value.ToString(); }
      }

      public TypeGuiHorizontalStackingType horizStacking
      {
         set { Fields["horizStacking"] = value.ToString(); }
      }

      public int padding
      {
         set { Fields["padding"] = value.ToString(); }
      }

      public TypeGuiStackingType stackingType
      {
         set { Fields["stackingType"] = value.ToString(); }
      }

      public TypeGuiVerticalStackingType vertStacking
      {
         set { Fields["vertStacking"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiStackControl(GuiStackControlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiStackControl ret = new GuiStackControl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiStackControlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
