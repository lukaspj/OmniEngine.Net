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
   public class GuiControlInstance : SimGroupInstance
   {
      public GuiControlInstance(string _name = "", string _className = "GuiControl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public String accelerator
      {
         set { Fields["accelerator"] = value.ToString(); }
      }

      public bool active
      {
         set { Fields["active"] = value.ToString(); }
      }

      public bool alpha
      {
         set { Fields["alpha"] = value.ToString(); }
      }

      public bool alphaFade
      {
         set { Fields["alphaFade"] = value.ToString(); }
      }

      public int alphaFadeTime
      {
         set { Fields["alphaFadeTime"] = value.ToString(); }
      }

      public float alphaValue
      {
         set { Fields["alphaValue"] = value.ToString(); }
      }

      public String altCommand
      {
         set { Fields["altCommand"] = value.ToString(); }
      }

      public ColorI backgroundColor
      {
         set { Fields["backgroundColor"] = value.ToString(); }
      }

      public String command
      {
         set { Fields["command"] = value.ToString(); }
      }

      public bool contextBackColor
      {
         set { Fields["contextBackColor"] = value.ToString(); }
      }

      public bool contextFillColor
      {
         set { Fields["contextFillColor"] = value.ToString(); }
      }

      public bool contextFontColor
      {
         set { Fields["contextFontColor"] = value.ToString(); }
      }

      public bool contextFontSize
      {
         set { Fields["contextFontSize"] = value.ToString(); }
      }

      public ColorI controlFillColor
      {
         set { Fields["controlFillColor"] = value.ToString(); }
      }

      public ColorI controlFontColor
      {
         set { Fields["controlFontColor"] = value.ToString(); }
      }

      public int controlFontSize
      {
         set { Fields["controlFontSize"] = value.ToString(); }
      }

      public Point2I extent
      {
         set { Fields["extent"] = value.ToString(); }
      }

      public TypeGuiHorizontalSizing horizSizing
      {
         set { Fields["horizSizing"] = value.ToString(); }
      }

      public int hovertime
      {
         set { Fields["hovertime"] = value.ToString(); }
      }

      public bool isContainer
      {
         set { Fields["isContainer"] = value.ToString(); }
      }

      public String langTableMod
      {
         set { Fields["langTableMod"] = value.ToString(); }
      }

      public bool lockControl
      {
         set { Fields["lockControl"] = value.ToString(); }
      }

      public Point2I maxExtent
      {
         set { Fields["maxExtent"] = value.ToString(); }
      }

      public Point2I minExtent
      {
         set { Fields["minExtent"] = value.ToString(); }
      }

      public String modal
      {
         set { Fields["modal"] = value.ToString(); }
      }

      public bool mouseOverAlpha
      {
         set { Fields["mouseOverAlpha"] = value.ToString(); }
      }

      public float mouseOverAlphaValue
      {
         set { Fields["mouseOverAlphaValue"] = value.ToString(); }
      }

      public bool moveControl
      {
         set { Fields["moveControl"] = value.ToString(); }
      }

      public Point2I position
      {
         set { Fields["position"] = value.ToString(); }
      }

      public GuiControlProfile profile
      {
         set { Fields["profile"] = value.ToString(); }
      }

      public String setFirstResponder
      {
         set { Fields["setFirstResponder"] = value.ToString(); }
      }

      public String tooltip
      {
         set { Fields["tooltip"] = value.ToString(); }
      }

      public GuiControlProfile tooltipProfile
      {
         set { Fields["tooltipProfile"] = value.ToString(); }
      }

      public String variable
      {
         set { Fields["variable"] = value.ToString(); }
      }

      public TypeGuiVerticalSizing vertSizing
      {
         set { Fields["vertSizing"] = value.ToString(); }
      }

      public bool visible
      {
         set { Fields["visible"] = value.ToString(); }
      }

      public bool windowSettings
      {
         set { Fields["windowSettings"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiControl(GuiControlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiControl ret = new GuiControl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiControlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
