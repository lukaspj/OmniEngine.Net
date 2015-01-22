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
   public class ParticleEmitterDataInstance : GameBaseDataInstance
   {
      public ParticleEmitterDataInstance(string _name = "", string _className = "ParticleEmitterData", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public Point3F alignDirection
      {
         set { Fields["alignDirection"] = value.ToString(); }
      }

      public bool alignParticles
      {
         set { Fields["alignParticles"] = value.ToString(); }
      }

      public float ambientFactor
      {
         set { Fields["ambientFactor"] = value.ToString(); }
      }

      public TypeParticleBlendStyle blendStyle
      {
         set { Fields["blendStyle"] = value.ToString(); }
      }

      public float ejectionOffset
      {
         set { Fields["ejectionOffset"] = value.ToString(); }
      }

      public float ejectionOffsetVariance
      {
         set { Fields["ejectionOffsetVariance"] = value.ToString(); }
      }

      public int ejectionPeriodMS
      {
         set { Fields["ejectionPeriodMS"] = value.ToString(); }
      }

      public float ejectionVelocity
      {
         set { Fields["ejectionVelocity"] = value.ToString(); }
      }

      public bool highResOnly
      {
         set { Fields["highResOnly"] = value.ToString(); }
      }

      public int lifetimeMS
      {
         set { Fields["lifetimeMS"] = value.ToString(); }
      }

      public int lifetimeVarianceMS
      {
         set { Fields["lifetimeVarianceMS"] = value.ToString(); }
      }

      public bool orientOnVelocity
      {
         set { Fields["orientOnVelocity"] = value.ToString(); }
      }

      public bool orientParticles
      {
         set { Fields["orientParticles"] = value.ToString(); }
      }

      public bool overrideAdvance
      {
         set { Fields["overrideAdvance"] = value.ToString(); }
      }

      public String particles
      {
         set { Fields["particles"] = value.ToString(); }
      }

      public int periodVarianceMS
      {
         set { Fields["periodVarianceMS"] = value.ToString(); }
      }

      public float phiReferenceVel
      {
         set { Fields["phiReferenceVel"] = value.ToString(); }
      }

      public float phiVariance
      {
         set { Fields["phiVariance"] = value.ToString(); }
      }

      public bool renderReflection
      {
         set { Fields["renderReflection"] = value.ToString(); }
      }

      public bool reverseOrder
      {
         set { Fields["reverseOrder"] = value.ToString(); }
      }

      public float softnessDistance
      {
         set { Fields["softnessDistance"] = value.ToString(); }
      }

      public bool sortParticles
      {
         set { Fields["sortParticles"] = value.ToString(); }
      }

      public String textureName
      {
         set { Fields["textureName"] = value.ToString(); }
      }

      public float thetaMax
      {
         set { Fields["thetaMax"] = value.ToString(); }
      }

      public float thetaMin
      {
         set { Fields["thetaMin"] = value.ToString(); }
      }

      public bool useEmitterColors
      {
         set { Fields["useEmitterColors"] = value.ToString(); }
      }

      public bool useEmitterSizes
      {
         set { Fields["useEmitterSizes"] = value.ToString(); }
      }

      public float velocityVariance
      {
         set { Fields["velocityVariance"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator ParticleEmitterData(ParticleEmitterDataInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         ParticleEmitterData ret = new ParticleEmitterData();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(ParticleEmitterDataInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
