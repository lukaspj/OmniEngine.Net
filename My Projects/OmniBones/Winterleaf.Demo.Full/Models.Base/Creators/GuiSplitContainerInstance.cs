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
   public class GuiSplitContainerInstance : GuiContainerInstance
   {
      public GuiSplitContainerInstance(string _name = "", string _className = "GuiSplitContainer", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public TypeGuiSplitFixedPanel fixedPanel
      {
         set { Fields["fixedPanel"] = value.ToString(); }
      }

      public int fixedSize
      {
         set { Fields["fixedSize"] = value.ToString(); }
      }

      public TypeGuiSplitOrientation orientation
      {
         set { Fields["orientation"] = value.ToString(); }
      }

      public Point2I splitPoint
      {
         set { Fields["splitPoint"] = value.ToString(); }
      }

      public int splitterSize
      {
         set { Fields["splitterSize"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiSplitContainer(GuiSplitContainerInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiSplitContainer ret = new GuiSplitContainer();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiSplitContainerInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
