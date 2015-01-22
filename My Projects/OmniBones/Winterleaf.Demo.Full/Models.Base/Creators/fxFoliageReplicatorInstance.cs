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
   public class fxFoliageReplicatorInstance : SceneObjectInstance
   {
      public fxFoliageReplicatorInstance(string _name = "", string _className = "fxFoliageReplicator", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
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

      public float AlphaCutoff
      {
         set { Fields["AlphaCutoff"] = value.ToString(); }
      }

      public int CullResolution
      {
         set { Fields["CullResolution"] = value.ToString(); }
      }

      public float DebugBoxHeight
      {
         set { Fields["DebugBoxHeight"] = value.ToString(); }
      }

      public float FadeInRegion
      {
         set { Fields["FadeInRegion"] = value.ToString(); }
      }

      public float FadeOutRegion
      {
         set { Fields["FadeOutRegion"] = value.ToString(); }
      }

      public bool FixAspectRatio
      {
         set { Fields["FixAspectRatio"] = value.ToString(); }
      }

      public bool FixSizeToMax
      {
         set { Fields["FixSizeToMax"] = value.ToString(); }
      }

      public int FoliageCount
      {
         set { Fields["FoliageCount"] = value.ToString(); }
      }

      public String FoliageFile
      {
         set { Fields["FoliageFile"] = value.ToString(); }
      }

      public int FoliageRetries
      {
         set { Fields["FoliageRetries"] = value.ToString(); }
      }

      public float GroundAlpha
      {
         set { Fields["GroundAlpha"] = value.ToString(); }
      }

      public bool HideFoliage
      {
         set { Fields["HideFoliage"] = value.ToString(); }
      }

      public int InnerRadiusX
      {
         set { Fields["InnerRadiusX"] = value.ToString(); }
      }

      public int InnerRadiusY
      {
         set { Fields["InnerRadiusY"] = value.ToString(); }
      }

      public bool LightOn
      {
         set { Fields["LightOn"] = value.ToString(); }
      }

      public bool LightSync
      {
         set { Fields["LightSync"] = value.ToString(); }
      }

      public float LightTime
      {
         set { Fields["LightTime"] = value.ToString(); }
      }

      public float MaxHeight
      {
         set { Fields["MaxHeight"] = value.ToString(); }
      }

      public float MaxLuminance
      {
         set { Fields["MaxLuminance"] = value.ToString(); }
      }

      public float MaxSwayTime
      {
         set { Fields["MaxSwayTime"] = value.ToString(); }
      }

      public float MaxWidth
      {
         set { Fields["MaxWidth"] = value.ToString(); }
      }

      public float MinHeight
      {
         set { Fields["MinHeight"] = value.ToString(); }
      }

      public float MinLuminance
      {
         set { Fields["MinLuminance"] = value.ToString(); }
      }

      public float MinSwayTime
      {
         set { Fields["MinSwayTime"] = value.ToString(); }
      }

      public float MinWidth
      {
         set { Fields["MinWidth"] = value.ToString(); }
      }

      public float OffsetZ
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

      public bool RandomFlip
      {
         set { Fields["RandomFlip"] = value.ToString(); }
      }

      public int Seed
      {
         set { Fields["Seed"] = value.ToString(); }
      }

      public bool ShowPlacementArea
      {
         set { Fields["ShowPlacementArea"] = value.ToString(); }
      }

      public float SwayMagFront
      {
         set { Fields["SwayMagFront"] = value.ToString(); }
      }

      public float SwayMagSide
      {
         set { Fields["SwayMagSide"] = value.ToString(); }
      }

      public bool SwayOn
      {
         set { Fields["SwayOn"] = value.ToString(); }
      }

      public bool SwaySync
      {
         set { Fields["SwaySync"] = value.ToString(); }
      }

      public bool UseCulling
      {
         set { Fields["UseCulling"] = value.ToString(); }
      }

      public bool UseDebugInfo
      {
         set { Fields["UseDebugInfo"] = value.ToString(); }
      }

      public bool UseTrueBillboards
      {
         set { Fields["UseTrueBillboards"] = value.ToString(); }
      }

      public float ViewClosest
      {
         set { Fields["ViewClosest"] = value.ToString(); }
      }

      public float ViewDistance
      {
         set { Fields["ViewDistance"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator fxFoliageReplicator(fxFoliageReplicatorInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         fxFoliageReplicator ret = new fxFoliageReplicator();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(fxFoliageReplicatorInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
