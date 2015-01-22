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
   public class ProjectileDataInstance : GameBaseDataInstance
   {
      public ProjectileDataInstance(string _name = "", string _className = "ProjectileData", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public int armingDelay
      {
         set { Fields["armingDelay"] = value.ToString(); }
      }

      public float bounceElasticity
      {
         set { Fields["bounceElasticity"] = value.ToString(); }
      }

      public float bounceFriction
      {
         set { Fields["bounceFriction"] = value.ToString(); }
      }

      public DecalData decal
      {
         set { Fields["decal"] = value.ToString(); }
      }

      public ExplosionData explosion
      {
         set { Fields["explosion"] = value.ToString(); }
      }

      public int fadeDelay
      {
         set { Fields["fadeDelay"] = value.ToString(); }
      }

      public float gravityMod
      {
         set { Fields["gravityMod"] = value.ToString(); }
      }

      public float impactForce
      {
         set { Fields["impactForce"] = value.ToString(); }
      }

      public bool isBallistic
      {
         set { Fields["isBallistic"] = value.ToString(); }
      }

      public int lifetime
      {
         set { Fields["lifetime"] = value.ToString(); }
      }

      public LightDescription lightDesc
      {
         set { Fields["lightDesc"] = value.ToString(); }
      }

      public float muzzleVelocity
      {
         set { Fields["muzzleVelocity"] = value.ToString(); }
      }

      public ParticleEmitterData particleEmitter
      {
         set { Fields["particleEmitter"] = value.ToString(); }
      }

      public ParticleEmitterData particleWaterEmitter
      {
         set { Fields["particleWaterEmitter"] = value.ToString(); }
      }

      public TypeShapeFilename projectileShapeName
      {
         set { Fields["projectileShapeName"] = value.ToString(); }
      }

      public Point3F scale
      {
         set { Fields["scale"] = value.ToString(); }
      }

      public TypeSFXTrackName sound
      {
         set { Fields["sound"] = value.ToString(); }
      }

      public SplashData splash
      {
         set { Fields["splash"] = value.ToString(); }
      }

      public float velInheritFactor
      {
         set { Fields["velInheritFactor"] = value.ToString(); }
      }

      public ExplosionData waterExplosion
      {
         set { Fields["waterExplosion"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator ProjectileData(ProjectileDataInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         ProjectileData ret = new ProjectileData();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(ProjectileDataInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
