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
   public class SplashDataInstance : GameBaseDataInstance
   {
      public SplashDataInstance(string _name = "", string _className = "SplashData", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float acceleration
      {
         set { Fields["acceleration"] = value.ToString(); }
      }

      private FieldWrapper<ColorF> _colors = new FieldWrapper<ColorF>();
      public FieldWrapper<ColorF> colors
      {
         get { _colors.Set(ref mFieldsDictionary, "colors"); return _colors; }
         set { _colors.Set(ref mFieldsDictionary, "colors"); }
      }

      public int delayMS
      {
         set { Fields["delayMS"] = value.ToString(); }
      }

      public int delayVariance
      {
         set { Fields["delayVariance"] = value.ToString(); }
      }

      public float ejectionAngle
      {
         set { Fields["ejectionAngle"] = value.ToString(); }
      }

      public float ejectionFreq
      {
         set { Fields["ejectionFreq"] = value.ToString(); }
      }

      private FieldWrapper<ParticleEmitterData> _emitter = new FieldWrapper<ParticleEmitterData>();
      public FieldWrapper<ParticleEmitterData> emitter
      {
         get { _emitter.Set(ref mFieldsDictionary, "emitter"); return _emitter; }
         set { _emitter.Set(ref mFieldsDictionary, "emitter"); }
      }

      public ExplosionData explosion
      {
         set { Fields["explosion"] = value.ToString(); }
      }

      public float height
      {
         set { Fields["height"] = value.ToString(); }
      }

      public int lifetimeMS
      {
         set { Fields["lifetimeMS"] = value.ToString(); }
      }

      public int lifetimeVariance
      {
         set { Fields["lifetimeVariance"] = value.ToString(); }
      }

      public int numSegments
      {
         set { Fields["numSegments"] = value.ToString(); }
      }

      public float ringLifetime
      {
         set { Fields["ringLifetime"] = value.ToString(); }
      }

      public Point3F scale
      {
         set { Fields["scale"] = value.ToString(); }
      }

      public SFXProfile soundProfile
      {
         set { Fields["soundProfile"] = value.ToString(); }
      }

      public float startRadius
      {
         set { Fields["startRadius"] = value.ToString(); }
      }

      public float texFactor
      {
         set { Fields["texFactor"] = value.ToString(); }
      }

      private FieldWrapper<String> _texture = new FieldWrapper<String>();
      public FieldWrapper<String> texture
      {
         get { _texture.Set(ref mFieldsDictionary, "texture"); return _texture; }
         set { _texture.Set(ref mFieldsDictionary, "texture"); }
      }

      public float texWrap
      {
         set { Fields["texWrap"] = value.ToString(); }
      }

      private FieldWrapper<float> _times = new FieldWrapper<float>();
      public FieldWrapper<float> times
      {
         get { _times.Set(ref mFieldsDictionary, "times"); return _times; }
         set { _times.Set(ref mFieldsDictionary, "times"); }
      }

      public float velocity
      {
         set { Fields["velocity"] = value.ToString(); }
      }

      public float width
      {
         set { Fields["width"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator SplashData(SplashDataInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         SplashData ret = new SplashData();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(SplashDataInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
