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
   public class TerrainEditorInstance : EditTSCtrlInstance
   {
      public TerrainEditorInstance(string _name = "", string _className = "TerrainEditor", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float adjustHeightMouseScale
      {
         set { Fields["adjustHeightMouseScale"] = value.ToString(); }
      }

      public float adjustHeightVal
      {
         set { Fields["adjustHeightVal"] = value.ToString(); }
      }

      public ColorI borderFillColor
      {
         set { Fields["borderFillColor"] = value.ToString(); }
      }

      public ColorI borderFrameColor
      {
         set { Fields["borderFrameColor"] = value.ToString(); }
      }

      public float borderHeight
      {
         set { Fields["borderHeight"] = value.ToString(); }
      }

      public bool borderLineMode
      {
         set { Fields["borderLineMode"] = value.ToString(); }
      }

      public bool isDirty
      {
         set { Fields["isDirty"] = value.ToString(); }
      }

      public bool isMissionDirty
      {
         set { Fields["isMissionDirty"] = value.ToString(); }
      }

      public int materialGroup
      {
         set { Fields["materialGroup"] = value.ToString(); }
      }

      public Point2I maxBrushSize
      {
         set { Fields["maxBrushSize"] = value.ToString(); }
      }

      public float noiseFactor
      {
         set { Fields["noiseFactor"] = value.ToString(); }
      }

      public int paintIndex
      {
         set { Fields["paintIndex"] = value.ToString(); }
      }

      public bool processUsesBrush
      {
         set { Fields["processUsesBrush"] = value.ToString(); }
      }

      public bool renderBorder
      {
         set { Fields["renderBorder"] = value.ToString(); }
      }

      public bool renderSolidBrush
      {
         set { Fields["renderSolidBrush"] = value.ToString(); }
      }

      public bool renderVertexSelection
      {
         set { Fields["renderVertexSelection"] = value.ToString(); }
      }

      public float scaleVal
      {
         set { Fields["scaleVal"] = value.ToString(); }
      }

      public bool selectionHidden
      {
         set { Fields["selectionHidden"] = value.ToString(); }
      }

      public float setHeightVal
      {
         set { Fields["setHeightVal"] = value.ToString(); }
      }

      public float smoothFactor
      {
         set { Fields["smoothFactor"] = value.ToString(); }
      }

      public String softSelectDefaultFilter
      {
         set { Fields["softSelectDefaultFilter"] = value.ToString(); }
      }

      public String softSelectFilter
      {
         set { Fields["softSelectFilter"] = value.ToString(); }
      }

      public float softSelectRadius
      {
         set { Fields["softSelectRadius"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator TerrainEditor(TerrainEditorInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         TerrainEditor ret = new TerrainEditor();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(TerrainEditorInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
