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
   public class VehicleDataInstance : ShapeBaseDataInstance
   {
      public VehicleDataInstance(string _name = "", string _className = "VehicleData", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float bodyFriction
      {
         set { Fields["bodyFriction"] = value.ToString(); }
      }

      public float bodyRestitution
      {
         set { Fields["bodyRestitution"] = value.ToString(); }
      }

      public float cameraDecay
      {
         set { Fields["cameraDecay"] = value.ToString(); }
      }

      public float cameraLag
      {
         set { Fields["cameraLag"] = value.ToString(); }
      }

      public float cameraOffset
      {
         set { Fields["cameraOffset"] = value.ToString(); }
      }

      public bool cameraRoll
      {
         set { Fields["cameraRoll"] = value.ToString(); }
      }

      public float collDamageMultiplier
      {
         set { Fields["collDamageMultiplier"] = value.ToString(); }
      }

      public float collDamageThresholdVel
      {
         set { Fields["collDamageThresholdVel"] = value.ToString(); }
      }

      public float collisionTol
      {
         set { Fields["collisionTol"] = value.ToString(); }
      }

      public float contactTol
      {
         set { Fields["contactTol"] = value.ToString(); }
      }

      private FieldWrapper<ParticleEmitterData> _damageEmitter = new FieldWrapper<ParticleEmitterData>();
      public FieldWrapper<ParticleEmitterData> damageEmitter
      {
         get { _damageEmitter.Set(ref mFieldsDictionary, "damageEmitter"); return _damageEmitter; }
         set { _damageEmitter.Set(ref mFieldsDictionary, "damageEmitter"); }
      }

      private FieldWrapper<Point3F> _damageEmitterOffset = new FieldWrapper<Point3F>();
      public FieldWrapper<Point3F> damageEmitterOffset
      {
         get { _damageEmitterOffset.Set(ref mFieldsDictionary, "damageEmitterOffset"); return _damageEmitterOffset; }
         set { _damageEmitterOffset.Set(ref mFieldsDictionary, "damageEmitterOffset"); }
      }

      private FieldWrapper<float> _damageLevelTolerance = new FieldWrapper<float>();
      public FieldWrapper<float> damageLevelTolerance
      {
         get { _damageLevelTolerance.Set(ref mFieldsDictionary, "damageLevelTolerance"); return _damageLevelTolerance; }
         set { _damageLevelTolerance.Set(ref mFieldsDictionary, "damageLevelTolerance"); }
      }

      public ParticleEmitterData dustEmitter
      {
         set { Fields["dustEmitter"] = value.ToString(); }
      }

      public float dustHeight
      {
         set { Fields["dustHeight"] = value.ToString(); }
      }

      public SFXProfile exitingWater
      {
         set { Fields["exitingWater"] = value.ToString(); }
      }

      public float exitSplashSoundVelocity
      {
         set { Fields["exitSplashSoundVelocity"] = value.ToString(); }
      }

      public SFXProfile hardImpactSound
      {
         set { Fields["hardImpactSound"] = value.ToString(); }
      }

      public float hardImpactSpeed
      {
         set { Fields["hardImpactSpeed"] = value.ToString(); }
      }

      public float hardSplashSoundVelocity
      {
         set { Fields["hardSplashSoundVelocity"] = value.ToString(); }
      }

      public SFXProfile impactWaterEasy
      {
         set { Fields["impactWaterEasy"] = value.ToString(); }
      }

      public SFXProfile impactWaterHard
      {
         set { Fields["impactWaterHard"] = value.ToString(); }
      }

      public SFXProfile impactWaterMedium
      {
         set { Fields["impactWaterMedium"] = value.ToString(); }
      }

      public int integration
      {
         set { Fields["integration"] = value.ToString(); }
      }

      public float jetEnergyDrain
      {
         set { Fields["jetEnergyDrain"] = value.ToString(); }
      }

      public float jetForce
      {
         set { Fields["jetForce"] = value.ToString(); }
      }

      public Point3F massBox
      {
         set { Fields["massBox"] = value.ToString(); }
      }

      public Point3F massCenter
      {
         set { Fields["massCenter"] = value.ToString(); }
      }

      public float maxDrag
      {
         set { Fields["maxDrag"] = value.ToString(); }
      }

      public float maxSteeringAngle
      {
         set { Fields["maxSteeringAngle"] = value.ToString(); }
      }

      public float mediumSplashSoundVelocity
      {
         set { Fields["mediumSplashSoundVelocity"] = value.ToString(); }
      }

      public float minDrag
      {
         set { Fields["minDrag"] = value.ToString(); }
      }

      public float minImpactSpeed
      {
         set { Fields["minImpactSpeed"] = value.ToString(); }
      }

      public float minJetEnergy
      {
         set { Fields["minJetEnergy"] = value.ToString(); }
      }

      public float minRollSpeed
      {
         set { Fields["minRollSpeed"] = value.ToString(); }
      }

      public float numDmgEmitterAreas
      {
         set { Fields["numDmgEmitterAreas"] = value.ToString(); }
      }

      public bool powerSteering
      {
         set { Fields["powerSteering"] = value.ToString(); }
      }

      public SFXProfile softImpactSound
      {
         set { Fields["softImpactSound"] = value.ToString(); }
      }

      public float softImpactSpeed
      {
         set { Fields["softImpactSpeed"] = value.ToString(); }
      }

      public float softSplashSoundVelocity
      {
         set { Fields["softSplashSoundVelocity"] = value.ToString(); }
      }

      private FieldWrapper<ParticleEmitterData> _splashEmitter = new FieldWrapper<ParticleEmitterData>();
      public FieldWrapper<ParticleEmitterData> splashEmitter
      {
         get { _splashEmitter.Set(ref mFieldsDictionary, "splashEmitter"); return _splashEmitter; }
         set { _splashEmitter.Set(ref mFieldsDictionary, "splashEmitter"); }
      }

      public float splashFreqMod
      {
         set { Fields["splashFreqMod"] = value.ToString(); }
      }

      public float splashVelEpsilon
      {
         set { Fields["splashVelEpsilon"] = value.ToString(); }
      }

      public float steeringReturn
      {
         set { Fields["steeringReturn"] = value.ToString(); }
      }

      public float steeringReturnSpeedScale
      {
         set { Fields["steeringReturnSpeedScale"] = value.ToString(); }
      }

      public float triggerDustHeight
      {
         set { Fields["triggerDustHeight"] = value.ToString(); }
      }

      public SFXProfile waterWakeSound
      {
         set { Fields["waterWakeSound"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator VehicleData(VehicleDataInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         VehicleData ret = new VehicleData();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(VehicleDataInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
