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
   public class GuiRectHandlesInstance : GuiControlInstance
   {
      public GuiRectHandlesInstance(string _name = "", string _className = "GuiRectHandles", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public ColorI handleColor
      {
         set { Fields["handleColor"] = value.ToString(); }
      }

      public RectF handleRect
      {
         set { Fields["handleRect"] = value.ToString(); }
      }

      public int handleSize
      {
         set { Fields["handleSize"] = value.ToString(); }
      }

      public bool useCustomColor
      {
         set { Fields["useCustomColor"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiRectHandles(GuiRectHandlesInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiRectHandles ret = new GuiRectHandles();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiRectHandlesInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
