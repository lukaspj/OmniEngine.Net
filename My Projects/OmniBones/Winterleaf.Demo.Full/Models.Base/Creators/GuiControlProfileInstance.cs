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
   public class GuiControlProfileInstance : SimObjectInstance
   {
      public GuiControlProfileInstance(string _name = "", string _className = "GuiControlProfile", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool autoSizeHeight
      {
         set { Fields["autoSizeHeight"] = value.ToString(); }
      }

      public bool autoSizeWidth
      {
         set { Fields["autoSizeWidth"] = value.ToString(); }
      }

      public ColorI bevelColorHL
      {
         set { Fields["bevelColorHL"] = value.ToString(); }
      }

      public ColorI bevelColorLL
      {
         set { Fields["bevelColorLL"] = value.ToString(); }
      }

      public String bitmap
      {
         set { Fields["bitmap"] = value.ToString(); }
      }

      public int border
      {
         set { Fields["border"] = value.ToString(); }
      }

      public ColorI borderColor
      {
         set { Fields["borderColor"] = value.ToString(); }
      }

      public ColorI borderColorHL
      {
         set { Fields["borderColorHL"] = value.ToString(); }
      }

      public ColorI borderColorNA
      {
         set { Fields["borderColorNA"] = value.ToString(); }
      }

      public int borderThickness
      {
         set { Fields["borderThickness"] = value.ToString(); }
      }

      public bool canKeyFocus
      {
         set { Fields["canKeyFocus"] = value.ToString(); }
      }

      public String category
      {
         set { Fields["category"] = value.ToString(); }
      }

      public TypeGuiControl controlBound
      {
         set { Fields["controlBound"] = value.ToString(); }
      }

      public ColorI cursorColor
      {
         set { Fields["cursorColor"] = value.ToString(); }
      }

      public ColorI fillColor
      {
         set { Fields["fillColor"] = value.ToString(); }
      }

      public ColorI fillColorHL
      {
         set { Fields["fillColorHL"] = value.ToString(); }
      }

      public ColorI fillColorNA
      {
         set { Fields["fillColorNA"] = value.ToString(); }
      }

      public ColorI fillColorSEL
      {
         set { Fields["fillColorSEL"] = value.ToString(); }
      }

      public TypeGuiFontCharset fontCharset
      {
         set { Fields["fontCharset"] = value.ToString(); }
      }

      public ColorI fontColor
      {
         set { Fields["fontColor"] = value.ToString(); }
      }

      public ColorI fontColorHL
      {
         set { Fields["fontColorHL"] = value.ToString(); }
      }

      public ColorI fontColorLink
      {
         set { Fields["fontColorLink"] = value.ToString(); }
      }

      public ColorI fontColorLinkHL
      {
         set { Fields["fontColorLinkHL"] = value.ToString(); }
      }

      public ColorI fontColorNA
      {
         set { Fields["fontColorNA"] = value.ToString(); }
      }

      private FieldWrapper<ColorI> _fontColors = new FieldWrapper<ColorI>();
      public FieldWrapper<ColorI> fontColors
      {
         get { _fontColors.Set(ref mFieldsDictionary, "fontColors"); return _fontColors; }
         set { _fontColors.Set(ref mFieldsDictionary, "fontColors"); }
      }

      public ColorI fontColorSEL
      {
         set { Fields["fontColorSEL"] = value.ToString(); }
      }

      public int fontSize
      {
         set { Fields["fontSize"] = value.ToString(); }
      }

      public String fontType
      {
         set { Fields["fontType"] = value.ToString(); }
      }

      public bool hasBitmapArray
      {
         set { Fields["hasBitmapArray"] = value.ToString(); }
      }

      public TypeGuiAlignmentType justify
      {
         set { Fields["justify"] = value.ToString(); }
      }

      public bool modal
      {
         set { Fields["modal"] = value.ToString(); }
      }

      public bool mouseOverSelected
      {
         set { Fields["mouseOverSelected"] = value.ToString(); }
      }

      public bool numbersOnly
      {
         set { Fields["numbersOnly"] = value.ToString(); }
      }

      public bool opaque
      {
         set { Fields["opaque"] = value.ToString(); }
      }

      public String profileForChildren
      {
         set { Fields["profileForChildren"] = value.ToString(); }
      }

      public bool returnTab
      {
         set { Fields["returnTab"] = value.ToString(); }
      }

      public TypeSFXTrackName soundButtonDown
      {
         set { Fields["soundButtonDown"] = value.ToString(); }
      }

      public TypeSFXTrackName soundButtonOver
      {
         set { Fields["soundButtonOver"] = value.ToString(); }
      }

      public bool tab
      {
         set { Fields["tab"] = value.ToString(); }
      }

      public Point2I textOffset
      {
         set { Fields["textOffset"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiControlProfile(GuiControlProfileInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiControlProfile ret = new GuiControlProfile();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiControlProfileInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
