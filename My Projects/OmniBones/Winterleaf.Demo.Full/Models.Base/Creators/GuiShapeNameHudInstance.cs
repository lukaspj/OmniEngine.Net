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
   public class GuiShapeNameHudInstance : GuiControlInstance
   {
      public GuiShapeNameHudInstance(string _name = "", string _className = "GuiShapeNameHud", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float distanceFade
      {
         set { Fields["distanceFade"] = value.ToString(); }
      }

      public ColorF fillColor
      {
         set { Fields["fillColor"] = value.ToString(); }
      }

      public ColorF frameColor
      {
         set { Fields["frameColor"] = value.ToString(); }
      }

      public ColorF labelFillColor
      {
         set { Fields["labelFillColor"] = value.ToString(); }
      }

      public ColorF labelFrameColor
      {
         set { Fields["labelFrameColor"] = value.ToString(); }
      }

      public Point2I labelPadding
      {
         set { Fields["labelPadding"] = value.ToString(); }
      }

      public bool showFill
      {
         set { Fields["showFill"] = value.ToString(); }
      }

      public bool showFrame
      {
         set { Fields["showFrame"] = value.ToString(); }
      }

      public bool showLabelFill
      {
         set { Fields["showLabelFill"] = value.ToString(); }
      }

      public bool showLabelFrame
      {
         set { Fields["showLabelFrame"] = value.ToString(); }
      }

      public ColorF textColor
      {
         set { Fields["textColor"] = value.ToString(); }
      }

      public float verticalOffset
      {
         set { Fields["verticalOffset"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiShapeNameHud(GuiShapeNameHudInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiShapeNameHud ret = new GuiShapeNameHud();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiShapeNameHudInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
