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
   public class ExplosionDataInstance : GameBaseDataInstance
   {
      public ExplosionDataInstance(string _name = "", string _className = "ExplosionData", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public Point3F camShakeAmp
      {
         set { Fields["camShakeAmp"] = value.ToString(); }
      }

      public float camShakeDuration
      {
         set { Fields["camShakeDuration"] = value.ToString(); }
      }

      public float camShakeFalloff
      {
         set { Fields["camShakeFalloff"] = value.ToString(); }
      }

      public Point3F camShakeFreq
      {
         set { Fields["camShakeFreq"] = value.ToString(); }
      }

      public float camShakeRadius
      {
         set { Fields["camShakeRadius"] = value.ToString(); }
      }

      public DebrisData debris
      {
         set { Fields["debris"] = value.ToString(); }
      }

      public int debrisNum
      {
         set { Fields["debrisNum"] = value.ToString(); }
      }

      public int debrisNumVariance
      {
         set { Fields["debrisNumVariance"] = value.ToString(); }
      }

      public float debrisPhiMax
      {
         set { Fields["debrisPhiMax"] = value.ToString(); }
      }

      public float debrisPhiMin
      {
         set { Fields["debrisPhiMin"] = value.ToString(); }
      }

      public float debrisThetaMax
      {
         set { Fields["debrisThetaMax"] = value.ToString(); }
      }

      public float debrisThetaMin
      {
         set { Fields["debrisThetaMin"] = value.ToString(); }
      }

      public float debrisVelocity
      {
         set { Fields["debrisVelocity"] = value.ToString(); }
      }

      public float debrisVelocityVariance
      {
         set { Fields["debrisVelocityVariance"] = value.ToString(); }
      }

      public int delayMS
      {
         set { Fields["delayMS"] = value.ToString(); }
      }

      public int delayVariance
      {
         set { Fields["delayVariance"] = value.ToString(); }
      }

      private FieldWrapper<ParticleEmitterData> _emitter = new FieldWrapper<ParticleEmitterData>();
      public FieldWrapper<ParticleEmitterData> emitter
      {
         get { _emitter.Set(ref mFieldsDictionary, "emitter"); return _emitter; }
         set { _emitter.Set(ref mFieldsDictionary, "emitter"); }
      }

      public Point3F explosionScale
      {
         set { Fields["explosionScale"] = value.ToString(); }
      }

      public TypeShapeFilename explosionShape
      {
         set { Fields["explosionShape"] = value.ToString(); }
      }

      public bool faceViewer
      {
         set { Fields["faceViewer"] = value.ToString(); }
      }

      public int lifetimeMS
      {
         set { Fields["lifetimeMS"] = value.ToString(); }
      }

      public int lifetimeVariance
      {
         set { Fields["lifetimeVariance"] = value.ToString(); }
      }

      public float lightEndBrightness
      {
         set { Fields["lightEndBrightness"] = value.ToString(); }
      }

      public ColorF lightEndColor
      {
         set { Fields["lightEndColor"] = value.ToString(); }
      }

      public float lightEndRadius
      {
         set { Fields["lightEndRadius"] = value.ToString(); }
      }

      public float lightNormalOffset
      {
         set { Fields["lightNormalOffset"] = value.ToString(); }
      }

      public float lightStartBrightness
      {
         set { Fields["lightStartBrightness"] = value.ToString(); }
      }

      public ColorF lightStartColor
      {
         set { Fields["lightStartColor"] = value.ToString(); }
      }

      public float lightStartRadius
      {
         set { Fields["lightStartRadius"] = value.ToString(); }
      }

      public float offset
      {
         set { Fields["offset"] = value.ToString(); }
      }

      public int particleDensity
      {
         set { Fields["particleDensity"] = value.ToString(); }
      }

      public ParticleEmitterData particleEmitter
      {
         set { Fields["particleEmitter"] = value.ToString(); }
      }

      public float particleRadius
      {
         set { Fields["particleRadius"] = value.ToString(); }
      }

      public float playSpeed
      {
         set { Fields["playSpeed"] = value.ToString(); }
      }

      public bool shakeCamera
      {
         set { Fields["shakeCamera"] = value.ToString(); }
      }

      private FieldWrapper<Point3F> _sizes = new FieldWrapper<Point3F>();
      public FieldWrapper<Point3F> sizes
      {
         get { _sizes.Set(ref mFieldsDictionary, "sizes"); return _sizes; }
         set { _sizes.Set(ref mFieldsDictionary, "sizes"); }
      }

      public SFXTrack soundProfile
      {
         set { Fields["soundProfile"] = value.ToString(); }
      }

      private FieldWrapper<ExplosionData> _subExplosion = new FieldWrapper<ExplosionData>();
      public FieldWrapper<ExplosionData> subExplosion
      {
         get { _subExplosion.Set(ref mFieldsDictionary, "subExplosion"); return _subExplosion; }
         set { _subExplosion.Set(ref mFieldsDictionary, "subExplosion"); }
      }

      private FieldWrapper<float> _times = new FieldWrapper<float>();
      public FieldWrapper<float> times
      {
         get { _times.Set(ref mFieldsDictionary, "times"); return _times; }
         set { _times.Set(ref mFieldsDictionary, "times"); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator ExplosionData(ExplosionDataInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         ExplosionData ret = new ExplosionData();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(ExplosionDataInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
