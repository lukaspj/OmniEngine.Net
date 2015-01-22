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
   public class fxShapeReplicatorInstance : SceneObjectInstance
   {
      public fxShapeReplicatorInstance(string _name = "", string _className = "fxShapeReplicator", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool AlignToTerrain
      {
         set { Fields["AlignToTerrain"] = value.ToString(); }
      }

      public int AllowedTerrainSlope
      {
         set { Fields["AllowedTerrainSlope"] = value.ToString(); }
      }

      public bool AllowOnStatics
      {
         set { Fields["AllowOnStatics"] = value.ToString(); }
      }

      public bool AllowOnTerrain
      {
         set { Fields["AllowOnTerrain"] = value.ToString(); }
      }

      public bool AllowOnWater
      {
         set { Fields["AllowOnWater"] = value.ToString(); }
      }

      public bool AllowWaterSurface
      {
         set { Fields["AllowWaterSurface"] = value.ToString(); }
      }

      public bool HideReplications
      {
         set { Fields["HideReplications"] = value.ToString(); }
      }

      public int InnerRadiusX
      {
         set { Fields["InnerRadiusX"] = value.ToString(); }
      }

      public int InnerRadiusY
      {
         set { Fields["InnerRadiusY"] = value.ToString(); }
      }

      public bool Interactions
      {
         set { Fields["Interactions"] = value.ToString(); }
      }

      public int OffsetZ
      {
         set { Fields["OffsetZ"] = value.ToString(); }
      }

      public int OuterRadiusX
      {
         set { Fields["OuterRadiusX"] = value.ToString(); }
      }

      public int OuterRadiusY
      {
         set { Fields["OuterRadiusY"] = value.ToString(); }
      }

      public int PlacementAreaHeight
      {
         set { Fields["PlacementAreaHeight"] = value.ToString(); }
      }

      public ColorF PlacementColour
      {
         set { Fields["PlacementColour"] = value.ToString(); }
      }

      public int Seed
      {
         set { Fields["Seed"] = value.ToString(); }
      }

      public int ShapeCount
      {
         set { Fields["ShapeCount"] = value.ToString(); }
      }

      public TypeShapeFilename ShapeFile
      {
         set { Fields["ShapeFile"] = value.ToString(); }
      }

      public int ShapeRetries
      {
         set { Fields["ShapeRetries"] = value.ToString(); }
      }

      public Point3F ShapeRotateMax
      {
         set { Fields["ShapeRotateMax"] = value.ToString(); }
      }

      public Point3F ShapeRotateMin
      {
         set { Fields["ShapeRotateMin"] = value.ToString(); }
      }

      public Point3F ShapeScaleMax
      {
         set { Fields["ShapeScaleMax"] = value.ToString(); }
      }

      public Point3F ShapeScaleMin
      {
         set { Fields["ShapeScaleMin"] = value.ToString(); }
      }

      public bool ShowPlacementArea
      {
         set { Fields["ShowPlacementArea"] = value.ToString(); }
      }

      public Point3F TerrainAlignment
      {
         set { Fields["TerrainAlignment"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator fxShapeReplicator(fxShapeReplicatorInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         fxShapeReplicator ret = new fxShapeReplicator();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(fxShapeReplicatorInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
