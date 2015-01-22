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
   public class GuiRiverEditorCtrlInstance : EditTSCtrlInstance
   {
      public GuiRiverEditorCtrlInstance(string _name = "", string _className = "GuiRiverEditorCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float DefaultDepth
      {
         set { Fields["DefaultDepth"] = value.ToString(); }
      }

      public Point3F DefaultNormal
      {
         set { Fields["DefaultNormal"] = value.ToString(); }
      }

      public float DefaultWidth
      {
         set { Fields["DefaultWidth"] = value.ToString(); }
      }

      public ColorI HoverNodeColor
      {
         set { Fields["HoverNodeColor"] = value.ToString(); }
      }

      public ColorI HoverSplineColor
      {
         set { Fields["HoverSplineColor"] = value.ToString(); }
      }

      public bool isDirty
      {
         set { Fields["isDirty"] = value.ToString(); }
      }

      public ColorI SelectedSplineColor
      {
         set { Fields["SelectedSplineColor"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiRiverEditorCtrl(GuiRiverEditorCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiRiverEditorCtrl ret = new GuiRiverEditorCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiRiverEditorCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
