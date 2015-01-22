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
   public class WaterObjectInstance : SceneObjectInstance
   {
      public WaterObjectInstance(string _name = "", string _className = "WaterObject", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public ColorI baseColor
      {
         set { Fields["baseColor"] = value.ToString(); }
      }

      public float clarity
      {
         set { Fields["clarity"] = value.ToString(); }
      }

      public TypeCubemapName cubemap
      {
         set { Fields["cubemap"] = value.ToString(); }
      }

      public float density
      {
         set { Fields["density"] = value.ToString(); }
      }

      public float depthGradientMax
      {
         set { Fields["depthGradientMax"] = value.ToString(); }
      }

      public TypeImageFilename depthGradientTex
      {
         set { Fields["depthGradientTex"] = value.ToString(); }
      }

      public float distortEndDist
      {
         set { Fields["distortEndDist"] = value.ToString(); }
      }

      public float distortFullDepth
      {
         set { Fields["distortFullDepth"] = value.ToString(); }
      }

      public float distortStartDist
      {
         set { Fields["distortStartDist"] = value.ToString(); }
      }

      public bool emissive
      {
         set { Fields["emissive"] = value.ToString(); }
      }

      public float foamAmbientLerp
      {
         set { Fields["foamAmbientLerp"] = value.ToString(); }
      }

      private FieldWrapper<Point2F> _foamDir = new FieldWrapper<Point2F>();
      public FieldWrapper<Point2F> foamDir
      {
         get { _foamDir.Set(ref mFieldsDictionary, "foamDir"); return _foamDir; }
         set { _foamDir.Set(ref mFieldsDictionary, "foamDir"); }
      }

      public float foamMaxDepth
      {
         set { Fields["foamMaxDepth"] = value.ToString(); }
      }

      private FieldWrapper<float> _foamOpacity = new FieldWrapper<float>();
      public FieldWrapper<float> foamOpacity
      {
         get { _foamOpacity.Set(ref mFieldsDictionary, "foamOpacity"); return _foamOpacity; }
         set { _foamOpacity.Set(ref mFieldsDictionary, "foamOpacity"); }
      }

      public float foamRippleInfluence
      {
         set { Fields["foamRippleInfluence"] = value.ToString(); }
      }

      private FieldWrapper<float> _foamSpeed = new FieldWrapper<float>();
      public FieldWrapper<float> foamSpeed
      {
         get { _foamSpeed.Set(ref mFieldsDictionary, "foamSpeed"); return _foamSpeed; }
         set { _foamSpeed.Set(ref mFieldsDictionary, "foamSpeed"); }
      }

      public TypeImageFilename foamTex
      {
         set { Fields["foamTex"] = value.ToString(); }
      }

      private FieldWrapper<Point2F> _foamTexScale = new FieldWrapper<Point2F>();
      public FieldWrapper<Point2F> foamTexScale
      {
         get { _foamTexScale.Set(ref mFieldsDictionary, "foamTexScale"); return _foamTexScale; }
         set { _foamTexScale.Set(ref mFieldsDictionary, "foamTexScale"); }
      }

      public float fresnelBias
      {
         set { Fields["fresnelBias"] = value.ToString(); }
      }

      public float fresnelPower
      {
         set { Fields["fresnelPower"] = value.ToString(); }
      }

      public bool fullReflect
      {
         set { Fields["fullReflect"] = value.ToString(); }
      }

      public String liquidType
      {
         set { Fields["liquidType"] = value.ToString(); }
      }

      public float overallFoamOpacity
      {
         set { Fields["overallFoamOpacity"] = value.ToString(); }
      }

      public float overallRippleMagnitude
      {
         set { Fields["overallRippleMagnitude"] = value.ToString(); }
      }

      public float overallWaveMagnitude
      {
         set { Fields["overallWaveMagnitude"] = value.ToString(); }
      }

      public float reflectDetailAdjust
      {
         set { Fields["reflectDetailAdjust"] = value.ToString(); }
      }

      public float reflectivity
      {
         set { Fields["reflectivity"] = value.ToString(); }
      }

      public int reflectMaxRateMs
      {
         set { Fields["reflectMaxRateMs"] = value.ToString(); }
      }

      public bool reflectNormalUp
      {
         set { Fields["reflectNormalUp"] = value.ToString(); }
      }

      public float reflectPriority
      {
         set { Fields["reflectPriority"] = value.ToString(); }
      }

      public int reflectTexSize
      {
         set { Fields["reflectTexSize"] = value.ToString(); }
      }

      private FieldWrapper<Point2F> _rippleDir = new FieldWrapper<Point2F>();
      public FieldWrapper<Point2F> rippleDir
      {
         get { _rippleDir.Set(ref mFieldsDictionary, "rippleDir"); return _rippleDir; }
         set { _rippleDir.Set(ref mFieldsDictionary, "rippleDir"); }
      }

      private FieldWrapper<float> _rippleMagnitude = new FieldWrapper<float>();
      public FieldWrapper<float> rippleMagnitude
      {
         get { _rippleMagnitude.Set(ref mFieldsDictionary, "rippleMagnitude"); return _rippleMagnitude; }
         set { _rippleMagnitude.Set(ref mFieldsDictionary, "rippleMagnitude"); }
      }

      private FieldWrapper<float> _rippleSpeed = new FieldWrapper<float>();
      public FieldWrapper<float> rippleSpeed
      {
         get { _rippleSpeed.Set(ref mFieldsDictionary, "rippleSpeed"); return _rippleSpeed; }
         set { _rippleSpeed.Set(ref mFieldsDictionary, "rippleSpeed"); }
      }

      public TypeImageFilename rippleTex
      {
         set { Fields["rippleTex"] = value.ToString(); }
      }

      private FieldWrapper<Point2F> _rippleTexScale = new FieldWrapper<Point2F>();
      public FieldWrapper<Point2F> rippleTexScale
      {
         get { _rippleTexScale.Set(ref mFieldsDictionary, "rippleTexScale"); return _rippleTexScale; }
         set { _rippleTexScale.Set(ref mFieldsDictionary, "rippleTexScale"); }
      }

      public TypeSFXAmbienceName soundAmbience
      {
         set { Fields["soundAmbience"] = value.ToString(); }
      }

      public ColorF specularColor
      {
         set { Fields["specularColor"] = value.ToString(); }
      }

      public float specularPower
      {
         set { Fields["specularPower"] = value.ToString(); }
      }

      public ColorI underwaterColor
      {
         set { Fields["underwaterColor"] = value.ToString(); }
      }

      public bool useOcclusionQuery
      {
         set { Fields["useOcclusionQuery"] = value.ToString(); }
      }

      public float viscosity
      {
         set { Fields["viscosity"] = value.ToString(); }
      }

      public float waterFogDensity
      {
         set { Fields["waterFogDensity"] = value.ToString(); }
      }

      public float waterFogDensityOffset
      {
         set { Fields["waterFogDensityOffset"] = value.ToString(); }
      }

      private FieldWrapper<Point2F> _waveDir = new FieldWrapper<Point2F>();
      public FieldWrapper<Point2F> waveDir
      {
         get { _waveDir.Set(ref mFieldsDictionary, "waveDir"); return _waveDir; }
         set { _waveDir.Set(ref mFieldsDictionary, "waveDir"); }
      }

      private FieldWrapper<float> _waveMagnitude = new FieldWrapper<float>();
      public FieldWrapper<float> waveMagnitude
      {
         get { _waveMagnitude.Set(ref mFieldsDictionary, "waveMagnitude"); return _waveMagnitude; }
         set { _waveMagnitude.Set(ref mFieldsDictionary, "waveMagnitude"); }
      }

      private FieldWrapper<float> _waveSpeed = new FieldWrapper<float>();
      public FieldWrapper<float> waveSpeed
      {
         get { _waveSpeed.Set(ref mFieldsDictionary, "waveSpeed"); return _waveSpeed; }
         set { _waveSpeed.Set(ref mFieldsDictionary, "waveSpeed"); }
      }

      public float wetDarkening
      {
         set { Fields["wetDarkening"] = value.ToString(); }
      }

      public float wetDepth
      {
         set { Fields["wetDepth"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator WaterObject(WaterObjectInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         WaterObject ret = new WaterObject();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(WaterObjectInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
