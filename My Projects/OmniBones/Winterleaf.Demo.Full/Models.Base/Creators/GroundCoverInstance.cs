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
   public class GroundCoverInstance : SceneObjectInstance
   {
      public GroundCoverInstance(string _name = "", string _className = "GroundCover", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      private FieldWrapper<RectF> _billboardUVs = new FieldWrapper<RectF>();
      public FieldWrapper<RectF> billboardUVs
      {
         get { _billboardUVs.Set(ref mFieldsDictionary, "billboardUVs"); return _billboardUVs; }
         set { _billboardUVs.Set(ref mFieldsDictionary, "billboardUVs"); }
      }

      private FieldWrapper<float> _clumpExponent = new FieldWrapper<float>();
      public FieldWrapper<float> clumpExponent
      {
         get { _clumpExponent.Set(ref mFieldsDictionary, "clumpExponent"); return _clumpExponent; }
         set { _clumpExponent.Set(ref mFieldsDictionary, "clumpExponent"); }
      }

      private FieldWrapper<float> _clumpRadius = new FieldWrapper<float>();
      public FieldWrapper<float> clumpRadius
      {
         get { _clumpRadius.Set(ref mFieldsDictionary, "clumpRadius"); return _clumpRadius; }
         set { _clumpRadius.Set(ref mFieldsDictionary, "clumpRadius"); }
      }

      public float dissolveRadius
      {
         set { Fields["dissolveRadius"] = value.ToString(); }
      }

      public int gridSize
      {
         set { Fields["gridSize"] = value.ToString(); }
      }

      private FieldWrapper<bool> _invertLayer = new FieldWrapper<bool>();
      public FieldWrapper<bool> invertLayer
      {
         get { _invertLayer.Set(ref mFieldsDictionary, "invertLayer"); return _invertLayer; }
         set { _invertLayer.Set(ref mFieldsDictionary, "invertLayer"); }
      }

      private FieldWrapper<TypeTerrainMaterialName> _layer = new FieldWrapper<TypeTerrainMaterialName>();
      public FieldWrapper<TypeTerrainMaterialName> layer
      {
         get { _layer.Set(ref mFieldsDictionary, "layer"); return _layer; }
         set { _layer.Set(ref mFieldsDictionary, "layer"); }
      }

      public bool lockFrustum
      {
         set { Fields["lockFrustum"] = value.ToString(); }
      }

      public TypeMaterialName material
      {
         set { Fields["material"] = value.ToString(); }
      }

      public float maxBillboardTiltAngle
      {
         set { Fields["maxBillboardTiltAngle"] = value.ToString(); }
      }

      private FieldWrapper<int> _maxClumpCount = new FieldWrapper<int>();
      public FieldWrapper<int> maxClumpCount
      {
         get { _maxClumpCount.Set(ref mFieldsDictionary, "maxClumpCount"); return _maxClumpCount; }
         set { _maxClumpCount.Set(ref mFieldsDictionary, "maxClumpCount"); }
      }

      public int maxElements
      {
         set { Fields["maxElements"] = value.ToString(); }
      }

      private FieldWrapper<float> _maxElevation = new FieldWrapper<float>();
      public FieldWrapper<float> maxElevation
      {
         get { _maxElevation.Set(ref mFieldsDictionary, "maxElevation"); return _maxElevation; }
         set { _maxElevation.Set(ref mFieldsDictionary, "maxElevation"); }
      }

      private FieldWrapper<float> _maxSlope = new FieldWrapper<float>();
      public FieldWrapper<float> maxSlope
      {
         get { _maxSlope.Set(ref mFieldsDictionary, "maxSlope"); return _maxSlope; }
         set { _maxSlope.Set(ref mFieldsDictionary, "maxSlope"); }
      }

      private FieldWrapper<int> _minClumpCount = new FieldWrapper<int>();
      public FieldWrapper<int> minClumpCount
      {
         get { _minClumpCount.Set(ref mFieldsDictionary, "minClumpCount"); return _minClumpCount; }
         set { _minClumpCount.Set(ref mFieldsDictionary, "minClumpCount"); }
      }

      private FieldWrapper<float> _minElevation = new FieldWrapper<float>();
      public FieldWrapper<float> minElevation
      {
         get { _minElevation.Set(ref mFieldsDictionary, "minElevation"); return _minElevation; }
         set { _minElevation.Set(ref mFieldsDictionary, "minElevation"); }
      }

      public bool noBillboards
      {
         set { Fields["noBillboards"] = value.ToString(); }
      }

      public bool noShapes
      {
         set { Fields["noShapes"] = value.ToString(); }
      }

      private FieldWrapper<float> _probability = new FieldWrapper<float>();
      public FieldWrapper<float> probability
      {
         get { _probability.Set(ref mFieldsDictionary, "probability"); return _probability; }
         set { _probability.Set(ref mFieldsDictionary, "probability"); }
      }

      public float radius
      {
         set { Fields["radius"] = value.ToString(); }
      }

      public float reflectScale
      {
         set { Fields["reflectScale"] = value.ToString(); }
      }

      public bool renderCells
      {
         set { Fields["renderCells"] = value.ToString(); }
      }

      public int seed
      {
         set { Fields["seed"] = value.ToString(); }
      }

      public float shapeCullRadius
      {
         set { Fields["shapeCullRadius"] = value.ToString(); }
      }

      private FieldWrapper<String> _shapeFilename = new FieldWrapper<String>();
      public FieldWrapper<String> shapeFilename
      {
         get { _shapeFilename.Set(ref mFieldsDictionary, "shapeFilename"); return _shapeFilename; }
         set { _shapeFilename.Set(ref mFieldsDictionary, "shapeFilename"); }
      }

      public bool shapesCastShadows
      {
         set { Fields["shapesCastShadows"] = value.ToString(); }
      }

      private FieldWrapper<float> _sizeExponent = new FieldWrapper<float>();
      public FieldWrapper<float> sizeExponent
      {
         get { _sizeExponent.Set(ref mFieldsDictionary, "sizeExponent"); return _sizeExponent; }
         set { _sizeExponent.Set(ref mFieldsDictionary, "sizeExponent"); }
      }

      private FieldWrapper<float> _sizeMax = new FieldWrapper<float>();
      public FieldWrapper<float> sizeMax
      {
         get { _sizeMax.Set(ref mFieldsDictionary, "sizeMax"); return _sizeMax; }
         set { _sizeMax.Set(ref mFieldsDictionary, "sizeMax"); }
      }

      private FieldWrapper<float> _sizeMin = new FieldWrapper<float>();
      public FieldWrapper<float> sizeMin
      {
         get { _sizeMin.Set(ref mFieldsDictionary, "sizeMin"); return _sizeMin; }
         set { _sizeMin.Set(ref mFieldsDictionary, "sizeMin"); }
      }

      public Point2F windDirection
      {
         set { Fields["windDirection"] = value.ToString(); }
      }

      public float windGustFrequency
      {
         set { Fields["windGustFrequency"] = value.ToString(); }
      }

      public float windGustLength
      {
         set { Fields["windGustLength"] = value.ToString(); }
      }

      public float windGustStrength
      {
         set { Fields["windGustStrength"] = value.ToString(); }
      }

      private FieldWrapper<float> _windScale = new FieldWrapper<float>();
      public FieldWrapper<float> windScale
      {
         get { _windScale.Set(ref mFieldsDictionary, "windScale"); return _windScale; }
         set { _windScale.Set(ref mFieldsDictionary, "windScale"); }
      }

      public float windTurbulenceFrequency
      {
         set { Fields["windTurbulenceFrequency"] = value.ToString(); }
      }

      public float windTurbulenceStrength
      {
         set { Fields["windTurbulenceStrength"] = value.ToString(); }
      }

      public float zOffset
      {
         set { Fields["zOffset"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GroundCover(GroundCoverInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GroundCover ret = new GroundCover();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GroundCoverInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
