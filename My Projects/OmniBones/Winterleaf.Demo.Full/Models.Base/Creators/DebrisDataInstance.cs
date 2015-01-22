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
   public class DebrisDataInstance : GameBaseDataInstance
   {
      public DebrisDataInstance(string _name = "", string _className = "DebrisData", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float baseRadius
      {
         set { Fields["baseRadius"] = value.ToString(); }
      }

      public int bounceVariance
      {
         set { Fields["bounceVariance"] = value.ToString(); }
      }

      public float elasticity
      {
         set { Fields["elasticity"] = value.ToString(); }
      }

      private FieldWrapper<ParticleEmitterData> _emitters = new FieldWrapper<ParticleEmitterData>();
      public FieldWrapper<ParticleEmitterData> emitters
      {
         get { _emitters.Set(ref mFieldsDictionary, "emitters"); return _emitters; }
         set { _emitters.Set(ref mFieldsDictionary, "emitters"); }
      }

      public bool explodeOnMaxBounce
      {
         set { Fields["explodeOnMaxBounce"] = value.ToString(); }
      }

      public ExplosionData explosion
      {
         set { Fields["explosion"] = value.ToString(); }
      }

      public bool fade
      {
         set { Fields["fade"] = value.ToString(); }
      }

      public float friction
      {
         set { Fields["friction"] = value.ToString(); }
      }

      public float gravModifier
      {
         set { Fields["gravModifier"] = value.ToString(); }
      }

      public bool ignoreWater
      {
         set { Fields["ignoreWater"] = value.ToString(); }
      }

      public float lifetime
      {
         set { Fields["lifetime"] = value.ToString(); }
      }

      public float lifetimeVariance
      {
         set { Fields["lifetimeVariance"] = value.ToString(); }
      }

      public float maxSpinSpeed
      {
         set { Fields["maxSpinSpeed"] = value.ToString(); }
      }

      public float minSpinSpeed
      {
         set { Fields["minSpinSpeed"] = value.ToString(); }
      }

      public int numBounces
      {
         set { Fields["numBounces"] = value.ToString(); }
      }

      public TypeShapeFilename shapeFile
      {
         set { Fields["shapeFile"] = value.ToString(); }
      }

      public bool snapOnMaxBounce
      {
         set { Fields["snapOnMaxBounce"] = value.ToString(); }
      }

      public bool staticOnMaxBounce
      {
         set { Fields["staticOnMaxBounce"] = value.ToString(); }
      }

      public float terminalVelocity
      {
         set { Fields["terminalVelocity"] = value.ToString(); }
      }

      public String texture
      {
         set { Fields["texture"] = value.ToString(); }
      }

      public bool useRadiusMass
      {
         set { Fields["useRadiusMass"] = value.ToString(); }
      }

      public float velocity
      {
         set { Fields["velocity"] = value.ToString(); }
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
      public static implicit operator DebrisData(DebrisDataInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         DebrisData ret = new DebrisData();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(DebrisDataInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
