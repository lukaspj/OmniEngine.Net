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
   public class EditTSCtrlInstance : GuiTSCtrlInstance
   {
      public EditTSCtrlInstance(string _name = "", string _className = "EditTSCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool allowBorderMove
      {
         set { Fields["allowBorderMove"] = value.ToString(); }
      }

      public int borderMovePixelSize
      {
         set { Fields["borderMovePixelSize"] = value.ToString(); }
      }

      public float borderMoveSpeed
      {
         set { Fields["borderMoveSpeed"] = value.ToString(); }
      }

      public int consoleCircleSegments
      {
         set { Fields["consoleCircleSegments"] = value.ToString(); }
      }

      public ColorI consoleFillColor
      {
         set { Fields["consoleFillColor"] = value.ToString(); }
      }

      public ColorI consoleFrameColor
      {
         set { Fields["consoleFrameColor"] = value.ToString(); }
      }

      public int consoleLineWidth
      {
         set { Fields["consoleLineWidth"] = value.ToString(); }
      }

      public int consoleSphereLevel
      {
         set { Fields["consoleSphereLevel"] = value.ToString(); }
      }

      public GizmoProfile gizmoProfile
      {
         set { Fields["gizmoProfile"] = value.ToString(); }
      }

      public ColorI gridColor
      {
         set { Fields["gridColor"] = value.ToString(); }
      }

      public ColorI gridMinorTickColor
      {
         set { Fields["gridMinorTickColor"] = value.ToString(); }
      }

      public ColorI gridOriginColor
      {
         set { Fields["gridOriginColor"] = value.ToString(); }
      }

      public float gridSize
      {
         set { Fields["gridSize"] = value.ToString(); }
      }

      public ColorI missionAreaFillColor
      {
         set { Fields["missionAreaFillColor"] = value.ToString(); }
      }

      public ColorI missionAreaFrameColor
      {
         set { Fields["missionAreaFrameColor"] = value.ToString(); }
      }

      public float missionAreaHeightAdjust
      {
         set { Fields["missionAreaHeightAdjust"] = value.ToString(); }
      }

      public bool renderMissionArea
      {
         set { Fields["renderMissionArea"] = value.ToString(); }
      }

      public bool renderOrthoGrid
      {
         set { Fields["renderOrthoGrid"] = value.ToString(); }
      }

      public float renderOrthoGridPixelBias
      {
         set { Fields["renderOrthoGridPixelBias"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator EditTSCtrl(EditTSCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         EditTSCtrl ret = new EditTSCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(EditTSCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
