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
   public class WorldEditorInstance : EditTSCtrlInstance
   {
      public WorldEditorInstance(string _name = "", string _className = "WorldEditor", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool boundingBoxCollision
      {
         set { Fields["boundingBoxCollision"] = value.ToString(); }
      }

      public String defaultHandle
      {
         set { Fields["defaultHandle"] = value.ToString(); }
      }

      public ColorI dragRectColor
      {
         set { Fields["dragRectColor"] = value.ToString(); }
      }

      public bool dropAtBounds
      {
         set { Fields["dropAtBounds"] = value.ToString(); }
      }

      public float dropAtScreenCenterMax
      {
         set { Fields["dropAtScreenCenterMax"] = value.ToString(); }
      }

      public float dropAtScreenCenterScalar
      {
         set { Fields["dropAtScreenCenterScalar"] = value.ToString(); }
      }

      public float dropBelowCameraOffset
      {
         set { Fields["dropBelowCameraOffset"] = value.ToString(); }
      }

      public TypeWorldEditorDropType dropType
      {
         set { Fields["dropType"] = value.ToString(); }
      }

      public ColorI faceSelectColor
      {
         set { Fields["faceSelectColor"] = value.ToString(); }
      }

      public bool fadeIcons
      {
         set { Fields["fadeIcons"] = value.ToString(); }
      }

      public float fadeIconsDist
      {
         set { Fields["fadeIconsDist"] = value.ToString(); }
      }

      public bool gridSnap
      {
         set { Fields["gridSnap"] = value.ToString(); }
      }

      public bool isDirty
      {
         set { Fields["isDirty"] = value.ToString(); }
      }

      public String lockedHandle
      {
         set { Fields["lockedHandle"] = value.ToString(); }
      }

      public bool objectMeshCollision
      {
         set { Fields["objectMeshCollision"] = value.ToString(); }
      }

      public bool objectsUseBoxCenter
      {
         set { Fields["objectsUseBoxCenter"] = value.ToString(); }
      }

      public ColorI objectTextColor
      {
         set { Fields["objectTextColor"] = value.ToString(); }
      }

      public ColorI objMouseOverColor
      {
         set { Fields["objMouseOverColor"] = value.ToString(); }
      }

      public ColorI objMouseOverSelectColor
      {
         set { Fields["objMouseOverSelectColor"] = value.ToString(); }
      }

      public ColorI objSelectColor
      {
         set { Fields["objSelectColor"] = value.ToString(); }
      }

      public String objTextFormat
      {
         set { Fields["objTextFormat"] = value.ToString(); }
      }

      public ColorI popupBackgroundColor
      {
         set { Fields["popupBackgroundColor"] = value.ToString(); }
      }

      public ColorI popupTextColor
      {
         set { Fields["popupTextColor"] = value.ToString(); }
      }

      public bool renderObjHandle
      {
         set { Fields["renderObjHandle"] = value.ToString(); }
      }

      public bool renderObjText
      {
         set { Fields["renderObjText"] = value.ToString(); }
      }

      public bool renderPopupBackground
      {
         set { Fields["renderPopupBackground"] = value.ToString(); }
      }

      public bool renderSelectionBox
      {
         set { Fields["renderSelectionBox"] = value.ToString(); }
      }

      public String selectHandle
      {
         set { Fields["selectHandle"] = value.ToString(); }
      }

      public ColorI selectionBoxColor
      {
         set { Fields["selectionBoxColor"] = value.ToString(); }
      }

      public bool selectionLocked
      {
         set { Fields["selectionLocked"] = value.ToString(); }
      }

      public bool showMousePopupInfo
      {
         set { Fields["showMousePopupInfo"] = value.ToString(); }
      }

      public bool stickToGround
      {
         set { Fields["stickToGround"] = value.ToString(); }
      }

      public bool toggleIgnoreList
      {
         set { Fields["toggleIgnoreList"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator WorldEditor(WorldEditorInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         WorldEditor ret = new WorldEditor();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(WorldEditorInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
