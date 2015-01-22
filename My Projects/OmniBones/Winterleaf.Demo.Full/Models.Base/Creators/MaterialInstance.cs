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
   public class MaterialInstance : BaseMaterialDefinitionInstance
   {
      public MaterialInstance(string _name = "", string _className = "Material", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      private FieldWrapper<float> _accuCoverage = new FieldWrapper<float>();
      public FieldWrapper<float> accuCoverage
      {
         get { _accuCoverage.Set(ref mFieldsDictionary, "accuCoverage"); return _accuCoverage; }
         set { _accuCoverage.Set(ref mFieldsDictionary, "accuCoverage"); }
      }

      private FieldWrapper<float> _accuDirection = new FieldWrapper<float>();
      public FieldWrapper<float> accuDirection
      {
         get { _accuDirection.Set(ref mFieldsDictionary, "accuDirection"); return _accuDirection; }
         set { _accuDirection.Set(ref mFieldsDictionary, "accuDirection"); }
      }

      private FieldWrapper<TypeImageFilename> _accuMap = new FieldWrapper<TypeImageFilename>();
      public FieldWrapper<TypeImageFilename> accuMap
      {
         get { _accuMap.Set(ref mFieldsDictionary, "accuMap"); return _accuMap; }
         set { _accuMap.Set(ref mFieldsDictionary, "accuMap"); }
      }

      private FieldWrapper<float> _accuScale = new FieldWrapper<float>();
      public FieldWrapper<float> accuScale
      {
         get { _accuScale.Set(ref mFieldsDictionary, "accuScale"); return _accuScale; }
         set { _accuScale.Set(ref mFieldsDictionary, "accuScale"); }
      }

      private FieldWrapper<float> _accuSpecular = new FieldWrapper<float>();
      public FieldWrapper<float> accuSpecular
      {
         get { _accuSpecular.Set(ref mFieldsDictionary, "accuSpecular"); return _accuSpecular; }
         set { _accuSpecular.Set(ref mFieldsDictionary, "accuSpecular"); }
      }

      private FieldWrapper<float> _accuStrength = new FieldWrapper<float>();
      public FieldWrapper<float> accuStrength
      {
         get { _accuStrength.Set(ref mFieldsDictionary, "accuStrength"); return _accuStrength; }
         set { _accuStrength.Set(ref mFieldsDictionary, "accuStrength"); }
      }

      public int alphaRef
      {
         set { Fields["alphaRef"] = value.ToString(); }
      }

      public bool alphaTest
      {
         set { Fields["alphaTest"] = value.ToString(); }
      }

      private FieldWrapper<TypeMaterialAnimType> _animFlags = new FieldWrapper<TypeMaterialAnimType>();
      public FieldWrapper<TypeMaterialAnimType> animFlags
      {
         get { _animFlags.Set(ref mFieldsDictionary, "animFlags"); return _animFlags; }
         set { _animFlags.Set(ref mFieldsDictionary, "animFlags"); }
      }

      public TypeImageFilename baseTex
      {
         set { Fields["baseTex"] = value.ToString(); }
      }

      private FieldWrapper<bool> _bumpAtlas = new FieldWrapper<bool>();
      public FieldWrapper<bool> bumpAtlas
      {
         get { _bumpAtlas.Set(ref mFieldsDictionary, "bumpAtlas"); return _bumpAtlas; }
         set { _bumpAtlas.Set(ref mFieldsDictionary, "bumpAtlas"); }
      }

      public TypeImageFilename bumpTex
      {
         set { Fields["bumpTex"] = value.ToString(); }
      }

      public bool castShadows
      {
         set { Fields["castShadows"] = value.ToString(); }
      }

      private FieldWrapper<Point2I> _cellIndex = new FieldWrapper<Point2I>();
      public FieldWrapper<Point2I> cellIndex
      {
         get { _cellIndex.Set(ref mFieldsDictionary, "cellIndex"); return _cellIndex; }
         set { _cellIndex.Set(ref mFieldsDictionary, "cellIndex"); }
      }

      private FieldWrapper<Point2I> _cellLayout = new FieldWrapper<Point2I>();
      public FieldWrapper<Point2I> cellLayout
      {
         get { _cellLayout.Set(ref mFieldsDictionary, "cellLayout"); return _cellLayout; }
         set { _cellLayout.Set(ref mFieldsDictionary, "cellLayout"); }
      }

      private FieldWrapper<int> _cellSize = new FieldWrapper<int>();
      public FieldWrapper<int> cellSize
      {
         get { _cellSize.Set(ref mFieldsDictionary, "cellSize"); return _cellSize; }
         set { _cellSize.Set(ref mFieldsDictionary, "cellSize"); }
      }

      public ColorF colorMultiply
      {
         set { Fields["colorMultiply"] = value.ToString(); }
      }

      public String cubemap
      {
         set { Fields["cubemap"] = value.ToString(); }
      }

      public TypeSFXTrackName customFootstepSound
      {
         set { Fields["customFootstepSound"] = value.ToString(); }
      }

      public TypeSFXTrackName customImpactSound
      {
         set { Fields["customImpactSound"] = value.ToString(); }
      }

      private FieldWrapper<TypeImageFilename> _detailMap = new FieldWrapper<TypeImageFilename>();
      public FieldWrapper<TypeImageFilename> detailMap
      {
         get { _detailMap.Set(ref mFieldsDictionary, "detailMap"); return _detailMap; }
         set { _detailMap.Set(ref mFieldsDictionary, "detailMap"); }
      }

      private FieldWrapper<TypeImageFilename> _detailNormalMap = new FieldWrapper<TypeImageFilename>();
      public FieldWrapper<TypeImageFilename> detailNormalMap
      {
         get { _detailNormalMap.Set(ref mFieldsDictionary, "detailNormalMap"); return _detailNormalMap; }
         set { _detailNormalMap.Set(ref mFieldsDictionary, "detailNormalMap"); }
      }

      private FieldWrapper<float> _detailNormalMapStrength = new FieldWrapper<float>();
      public FieldWrapper<float> detailNormalMapStrength
      {
         get { _detailNormalMapStrength.Set(ref mFieldsDictionary, "detailNormalMapStrength"); return _detailNormalMapStrength; }
         set { _detailNormalMapStrength.Set(ref mFieldsDictionary, "detailNormalMapStrength"); }
      }

      private FieldWrapper<Point2F> _detailScale = new FieldWrapper<Point2F>();
      public FieldWrapper<Point2F> detailScale
      {
         get { _detailScale.Set(ref mFieldsDictionary, "detailScale"); return _detailScale; }
         set { _detailScale.Set(ref mFieldsDictionary, "detailScale"); }
      }

      public TypeImageFilename detailTex
      {
         set { Fields["detailTex"] = value.ToString(); }
      }

      private FieldWrapper<ColorF> _diffuseColor = new FieldWrapper<ColorF>();
      public FieldWrapper<ColorF> diffuseColor
      {
         get { _diffuseColor.Set(ref mFieldsDictionary, "diffuseColor"); return _diffuseColor; }
         set { _diffuseColor.Set(ref mFieldsDictionary, "diffuseColor"); }
      }

      private FieldWrapper<TypeImageFilename> _diffuseMap = new FieldWrapper<TypeImageFilename>();
      public FieldWrapper<TypeImageFilename> diffuseMap
      {
         get { _diffuseMap.Set(ref mFieldsDictionary, "diffuseMap"); return _diffuseMap; }
         set { _diffuseMap.Set(ref mFieldsDictionary, "diffuseMap"); }
      }

      public float directSoundOcclusion
      {
         set { Fields["directSoundOcclusion"] = value.ToString(); }
      }

      public bool doubleSided
      {
         set { Fields["doubleSided"] = value.ToString(); }
      }

      public bool dynamicCubemap
      {
         set { Fields["dynamicCubemap"] = value.ToString(); }
      }

      private FieldWrapper<ColorF> _effectColor = new FieldWrapper<ColorF>();
      public FieldWrapper<ColorF> effectColor
      {
         get { _effectColor.Set(ref mFieldsDictionary, "effectColor"); return _effectColor; }
         set { _effectColor.Set(ref mFieldsDictionary, "effectColor"); }
      }

      private FieldWrapper<bool> _emissive = new FieldWrapper<bool>();
      public FieldWrapper<bool> emissive
      {
         get { _emissive.Set(ref mFieldsDictionary, "emissive"); return _emissive; }
         set { _emissive.Set(ref mFieldsDictionary, "emissive"); }
      }

      private FieldWrapper<TypeImageFilename> _envMap = new FieldWrapper<TypeImageFilename>();
      public FieldWrapper<TypeImageFilename> envMap
      {
         get { _envMap.Set(ref mFieldsDictionary, "envMap"); return _envMap; }
         set { _envMap.Set(ref mFieldsDictionary, "envMap"); }
      }

      public TypeImageFilename envTex
      {
         set { Fields["envTex"] = value.ToString(); }
      }

      public int footstepSoundId
      {
         set { Fields["footstepSoundId"] = value.ToString(); }
      }

      public float friction
      {
         set { Fields["friction"] = value.ToString(); }
      }

      private FieldWrapper<bool> _glow = new FieldWrapper<bool>();
      public FieldWrapper<bool> glow
      {
         get { _glow.Set(ref mFieldsDictionary, "glow"); return _glow; }
         set { _glow.Set(ref mFieldsDictionary, "glow"); }
      }

      public int impactSoundId
      {
         set { Fields["impactSoundId"] = value.ToString(); }
      }

      private FieldWrapper<TypeImageFilename> _lightMap = new FieldWrapper<TypeImageFilename>();
      public FieldWrapper<TypeImageFilename> lightMap
      {
         get { _lightMap.Set(ref mFieldsDictionary, "lightMap"); return _lightMap; }
         set { _lightMap.Set(ref mFieldsDictionary, "lightMap"); }
      }

      public String mapTo
      {
         set { Fields["mapTo"] = value.ToString(); }
      }

      private FieldWrapper<float> _minnaertConstant = new FieldWrapper<float>();
      public FieldWrapper<float> minnaertConstant
      {
         get { _minnaertConstant.Set(ref mFieldsDictionary, "minnaertConstant"); return _minnaertConstant; }
         set { _minnaertConstant.Set(ref mFieldsDictionary, "minnaertConstant"); }
      }

      private FieldWrapper<TypeImageFilename> _normalMap = new FieldWrapper<TypeImageFilename>();
      public FieldWrapper<TypeImageFilename> normalMap
      {
         get { _normalMap.Set(ref mFieldsDictionary, "normalMap"); return _normalMap; }
         set { _normalMap.Set(ref mFieldsDictionary, "normalMap"); }
      }

      private FieldWrapper<TypeImageFilename> _overlayMap = new FieldWrapper<TypeImageFilename>();
      public FieldWrapper<TypeImageFilename> overlayMap
      {
         get { _overlayMap.Set(ref mFieldsDictionary, "overlayMap"); return _overlayMap; }
         set { _overlayMap.Set(ref mFieldsDictionary, "overlayMap"); }
      }

      public TypeImageFilename overlayTex
      {
         set { Fields["overlayTex"] = value.ToString(); }
      }

      private FieldWrapper<float> _parallaxScale = new FieldWrapper<float>();
      public FieldWrapper<float> parallaxScale
      {
         get { _parallaxScale.Set(ref mFieldsDictionary, "parallaxScale"); return _parallaxScale; }
         set { _parallaxScale.Set(ref mFieldsDictionary, "parallaxScale"); }
      }

      private FieldWrapper<bool> _pixelSpecular = new FieldWrapper<bool>();
      public FieldWrapper<bool> pixelSpecular
      {
         get { _pixelSpecular.Set(ref mFieldsDictionary, "pixelSpecular"); return _pixelSpecular; }
         set { _pixelSpecular.Set(ref mFieldsDictionary, "pixelSpecular"); }
      }

      public bool planarReflection
      {
         set { Fields["planarReflection"] = value.ToString(); }
      }

      public float reverbSoundOcclusion
      {
         set { Fields["reverbSoundOcclusion"] = value.ToString(); }
      }

      private FieldWrapper<Point2F> _rotPivotOffset = new FieldWrapper<Point2F>();
      public FieldWrapper<Point2F> rotPivotOffset
      {
         get { _rotPivotOffset.Set(ref mFieldsDictionary, "rotPivotOffset"); return _rotPivotOffset; }
         set { _rotPivotOffset.Set(ref mFieldsDictionary, "rotPivotOffset"); }
      }

      private FieldWrapper<float> _rotSpeed = new FieldWrapper<float>();
      public FieldWrapper<float> rotSpeed
      {
         get { _rotSpeed.Set(ref mFieldsDictionary, "rotSpeed"); return _rotSpeed; }
         set { _rotSpeed.Set(ref mFieldsDictionary, "rotSpeed"); }
      }

      private FieldWrapper<Point2F> _scrollDir = new FieldWrapper<Point2F>();
      public FieldWrapper<Point2F> scrollDir
      {
         get { _scrollDir.Set(ref mFieldsDictionary, "scrollDir"); return _scrollDir; }
         set { _scrollDir.Set(ref mFieldsDictionary, "scrollDir"); }
      }

      private FieldWrapper<float> _scrollSpeed = new FieldWrapper<float>();
      public FieldWrapper<float> scrollSpeed
      {
         get { _scrollSpeed.Set(ref mFieldsDictionary, "scrollSpeed"); return _scrollSpeed; }
         set { _scrollSpeed.Set(ref mFieldsDictionary, "scrollSpeed"); }
      }

      private FieldWrapper<float> _sequenceFramePerSec = new FieldWrapper<float>();
      public FieldWrapper<float> sequenceFramePerSec
      {
         get { _sequenceFramePerSec.Set(ref mFieldsDictionary, "sequenceFramePerSec"); return _sequenceFramePerSec; }
         set { _sequenceFramePerSec.Set(ref mFieldsDictionary, "sequenceFramePerSec"); }
      }

      private FieldWrapper<float> _sequenceSegmentSize = new FieldWrapper<float>();
      public FieldWrapper<float> sequenceSegmentSize
      {
         get { _sequenceSegmentSize.Set(ref mFieldsDictionary, "sequenceSegmentSize"); return _sequenceSegmentSize; }
         set { _sequenceSegmentSize.Set(ref mFieldsDictionary, "sequenceSegmentSize"); }
      }

      public bool showDust
      {
         set { Fields["showDust"] = value.ToString(); }
      }

      public bool showFootprints
      {
         set { Fields["showFootprints"] = value.ToString(); }
      }

      private FieldWrapper<ColorF> _specular = new FieldWrapper<ColorF>();
      public FieldWrapper<ColorF> specular
      {
         get { _specular.Set(ref mFieldsDictionary, "specular"); return _specular; }
         set { _specular.Set(ref mFieldsDictionary, "specular"); }
      }

      private FieldWrapper<TypeImageFilename> _specularMap = new FieldWrapper<TypeImageFilename>();
      public FieldWrapper<TypeImageFilename> specularMap
      {
         get { _specularMap.Set(ref mFieldsDictionary, "specularMap"); return _specularMap; }
         set { _specularMap.Set(ref mFieldsDictionary, "specularMap"); }
      }

      private FieldWrapper<float> _specularPower = new FieldWrapper<float>();
      public FieldWrapper<float> specularPower
      {
         get { _specularPower.Set(ref mFieldsDictionary, "specularPower"); return _specularPower; }
         set { _specularPower.Set(ref mFieldsDictionary, "specularPower"); }
      }

      private FieldWrapper<float> _specularStrength = new FieldWrapper<float>();
      public FieldWrapper<float> specularStrength
      {
         get { _specularStrength.Set(ref mFieldsDictionary, "specularStrength"); return _specularStrength; }
         set { _specularStrength.Set(ref mFieldsDictionary, "specularStrength"); }
      }

      private FieldWrapper<bool> _subSurface = new FieldWrapper<bool>();
      public FieldWrapper<bool> subSurface
      {
         get { _subSurface.Set(ref mFieldsDictionary, "subSurface"); return _subSurface; }
         set { _subSurface.Set(ref mFieldsDictionary, "subSurface"); }
      }

      private FieldWrapper<ColorF> _subSurfaceColor = new FieldWrapper<ColorF>();
      public FieldWrapper<ColorF> subSurfaceColor
      {
         get { _subSurfaceColor.Set(ref mFieldsDictionary, "subSurfaceColor"); return _subSurfaceColor; }
         set { _subSurfaceColor.Set(ref mFieldsDictionary, "subSurfaceColor"); }
      }

      private FieldWrapper<float> _subSurfaceRolloff = new FieldWrapper<float>();
      public FieldWrapper<float> subSurfaceRolloff
      {
         get { _subSurfaceRolloff.Set(ref mFieldsDictionary, "subSurfaceRolloff"); return _subSurfaceRolloff; }
         set { _subSurfaceRolloff.Set(ref mFieldsDictionary, "subSurfaceRolloff"); }
      }

      private FieldWrapper<TypeImageFilename> _toneMap = new FieldWrapper<TypeImageFilename>();
      public FieldWrapper<TypeImageFilename> toneMap
      {
         get { _toneMap.Set(ref mFieldsDictionary, "toneMap"); return _toneMap; }
         set { _toneMap.Set(ref mFieldsDictionary, "toneMap"); }
      }

      public bool translucent
      {
         set { Fields["translucent"] = value.ToString(); }
      }

      public TypeMaterialBlendOp translucentBlendOp
      {
         set { Fields["translucentBlendOp"] = value.ToString(); }
      }

      public bool translucentZWrite
      {
         set { Fields["translucentZWrite"] = value.ToString(); }
      }

      private FieldWrapper<bool> _useAnisotropic = new FieldWrapper<bool>();
      public FieldWrapper<bool> useAnisotropic
      {
         get { _useAnisotropic.Set(ref mFieldsDictionary, "useAnisotropic"); return _useAnisotropic; }
         set { _useAnisotropic.Set(ref mFieldsDictionary, "useAnisotropic"); }
      }

      private FieldWrapper<bool> _vertColor = new FieldWrapper<bool>();
      public FieldWrapper<bool> vertColor
      {
         get { _vertColor.Set(ref mFieldsDictionary, "vertColor"); return _vertColor; }
         set { _vertColor.Set(ref mFieldsDictionary, "vertColor"); }
      }

      private FieldWrapper<bool> _vertLit = new FieldWrapper<bool>();
      public FieldWrapper<bool> vertLit
      {
         get { _vertLit.Set(ref mFieldsDictionary, "vertLit"); return _vertLit; }
         set { _vertLit.Set(ref mFieldsDictionary, "vertLit"); }
      }

      private FieldWrapper<float> _waveAmp = new FieldWrapper<float>();
      public FieldWrapper<float> waveAmp
      {
         get { _waveAmp.Set(ref mFieldsDictionary, "waveAmp"); return _waveAmp; }
         set { _waveAmp.Set(ref mFieldsDictionary, "waveAmp"); }
      }

      private FieldWrapper<float> _waveFreq = new FieldWrapper<float>();
      public FieldWrapper<float> waveFreq
      {
         get { _waveFreq.Set(ref mFieldsDictionary, "waveFreq"); return _waveFreq; }
         set { _waveFreq.Set(ref mFieldsDictionary, "waveFreq"); }
      }

      private FieldWrapper<TypeMaterialWaveType> _waveType = new FieldWrapper<TypeMaterialWaveType>();
      public FieldWrapper<TypeMaterialWaveType> waveType
      {
         get { _waveType.Set(ref mFieldsDictionary, "waveType"); return _waveType; }
         set { _waveType.Set(ref mFieldsDictionary, "waveType"); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator Material(MaterialInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         Material ret = new Material();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(MaterialInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
