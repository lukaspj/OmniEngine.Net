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
   public class GuiShapeEdPreviewInstance : EditTSCtrlInstance
   {
      public GuiShapeEdPreviewInstance(string _name = "", string _className = "GuiShapeEdPreview", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public int activeThread
      {
         set { Fields["activeThread"] = value.ToString(); }
      }

      public int colMeshes
      {
         set { Fields["colMeshes"] = value.ToString(); }
      }

      public int colPolys
      {
         set { Fields["colPolys"] = value.ToString(); }
      }

      public int currentDL
      {
         set { Fields["currentDL"] = value.ToString(); }
      }

      public int detailPolys
      {
         set { Fields["detailPolys"] = value.ToString(); }
      }

      public int detailSize
      {
         set { Fields["detailSize"] = value.ToString(); }
      }

      public bool editSun
      {
         set { Fields["editSun"] = value.ToString(); }
      }

      public bool fixedDetail
      {
         set { Fields["fixedDetail"] = value.ToString(); }
      }

      public Point2I gridDimension
      {
         set { Fields["gridDimension"] = value.ToString(); }
      }

      public int numBones
      {
         set { Fields["numBones"] = value.ToString(); }
      }

      public int numDrawCalls
      {
         set { Fields["numDrawCalls"] = value.ToString(); }
      }

      public int numMaterials
      {
         set { Fields["numMaterials"] = value.ToString(); }
      }

      public int numWeights
      {
         set { Fields["numWeights"] = value.ToString(); }
      }

      public float orbitDist
      {
         set { Fields["orbitDist"] = value.ToString(); }
      }

      public float pixelSize
      {
         set { Fields["pixelSize"] = value.ToString(); }
      }

      public bool renderBounds
      {
         set { Fields["renderBounds"] = value.ToString(); }
      }

      public bool renderColMeshes
      {
         set { Fields["renderColMeshes"] = value.ToString(); }
      }

      public bool renderGhost
      {
         set { Fields["renderGhost"] = value.ToString(); }
      }

      public bool renderGrid
      {
         set { Fields["renderGrid"] = value.ToString(); }
      }

      public bool renderMounts
      {
         set { Fields["renderMounts"] = value.ToString(); }
      }

      public bool renderNodes
      {
         set { Fields["renderNodes"] = value.ToString(); }
      }

      public bool renderObjBox
      {
         set { Fields["renderObjBox"] = value.ToString(); }
      }

      public int selectedNode
      {
         set { Fields["selectedNode"] = value.ToString(); }
      }

      public int selectedObjDetail
      {
         set { Fields["selectedObjDetail"] = value.ToString(); }
      }

      public int selectedObject
      {
         set { Fields["selectedObject"] = value.ToString(); }
      }

      public ColorI sunAmbient
      {
         set { Fields["sunAmbient"] = value.ToString(); }
      }

      public float sunAngleX
      {
         set { Fields["sunAngleX"] = value.ToString(); }
      }

      public float sunAngleZ
      {
         set { Fields["sunAngleZ"] = value.ToString(); }
      }

      public ColorI sunDiffuse
      {
         set { Fields["sunDiffuse"] = value.ToString(); }
      }

      public int threadDirection
      {
         set { Fields["threadDirection"] = value.ToString(); }
      }

      public bool threadPingPong
      {
         set { Fields["threadPingPong"] = value.ToString(); }
      }

      public float threadPos
      {
         set { Fields["threadPos"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiShapeEdPreview(GuiShapeEdPreviewInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiShapeEdPreview ret = new GuiShapeEdPreview();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiShapeEdPreviewInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
