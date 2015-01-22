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
   public class ParticleDataInstance : SimDataBlockInstance
   {
      public ParticleDataInstance(string _name = "", string _className = "ParticleData", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool animateTexture
      {
         set { Fields["animateTexture"] = value.ToString(); }
      }

      public String animTexFrames
      {
         set { Fields["animTexFrames"] = value.ToString(); }
      }

      public String animTexName
      {
         set { Fields["animTexName"] = value.ToString(); }
      }

      public Point2I animTexTiling
      {
         set { Fields["animTexTiling"] = value.ToString(); }
      }

      private FieldWrapper<ColorF> _colors = new FieldWrapper<ColorF>();
      public FieldWrapper<ColorF> colors
      {
         get { _colors.Set(ref mFieldsDictionary, "colors"); return _colors; }
         set { _colors.Set(ref mFieldsDictionary, "colors"); }
      }

      public float constantAcceleration
      {
         set { Fields["constantAcceleration"] = value.ToString(); }
      }

      public float dragCoefficient
      {
         set { Fields["dragCoefficient"] = value.ToString(); }
      }

      public int framesPerSec
      {
         set { Fields["framesPerSec"] = value.ToString(); }
      }

      public float gravityCoefficient
      {
         set { Fields["gravityCoefficient"] = value.ToString(); }
      }

      public float inheritedVelFactor
      {
         set { Fields["inheritedVelFactor"] = value.ToString(); }
      }

      public int lifetimeMS
      {
         set { Fields["lifetimeMS"] = value.ToString(); }
      }

      public int lifetimeVarianceMS
      {
         set { Fields["lifetimeVarianceMS"] = value.ToString(); }
      }

      public float sizes
      {
         set { Fields["sizes"] = value.ToString(); }
      }

      public float spinRandomMax
      {
         set { Fields["spinRandomMax"] = value.ToString(); }
      }

      public float spinRandomMin
      {
         set { Fields["spinRandomMin"] = value.ToString(); }
      }

      public float spinSpeed
      {
         set { Fields["spinSpeed"] = value.ToString(); }
      }

      private FieldWrapper<Point2F> _textureCoords = new FieldWrapper<Point2F>();
      public FieldWrapper<Point2F> textureCoords
      {
         get { _textureCoords.Set(ref mFieldsDictionary, "textureCoords"); return _textureCoords; }
         set { _textureCoords.Set(ref mFieldsDictionary, "textureCoords"); }
      }

      public String textureName
      {
         set { Fields["textureName"] = value.ToString(); }
      }

      public float times
      {
         set { Fields["times"] = value.ToString(); }
      }

      public bool useInvAlpha
      {
         set { Fields["useInvAlpha"] = value.ToString(); }
      }

      public float windCoefficient
      {
         set { Fields["windCoefficient"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator ParticleData(ParticleDataInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         ParticleData ret = new ParticleData();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(ParticleDataInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
