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
   public class VolumetricFogInstance : SceneObjectInstance
   {
      public VolumetricFogInstance(string _name = "", string _className = "VolumetricFog", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float FadeSize
      {
         set { Fields["FadeSize"] = value.ToString(); }
      }

      public ColorI FogColor
      {
         set { Fields["FogColor"] = value.ToString(); }
      }

      public float FogDensity
      {
         set { Fields["FogDensity"] = value.ToString(); }
      }

      public bool IgnoreWater
      {
         set { Fields["IgnoreWater"] = value.ToString(); }
      }

      public float MinSize
      {
         set { Fields["MinSize"] = value.ToString(); }
      }

      public float modStrength
      {
         set { Fields["modStrength"] = value.ToString(); }
      }

      public Point2F PrimSpeed
      {
         set { Fields["PrimSpeed"] = value.ToString(); }
      }

      public Point2F SecSpeed
      {
         set { Fields["SecSpeed"] = value.ToString(); }
      }

      public TypeShapeFilename shapeName
      {
         set { Fields["shapeName"] = value.ToString(); }
      }

      public TypeImageFilename texture
      {
         set { Fields["texture"] = value.ToString(); }
      }

      public float tiles
      {
         set { Fields["tiles"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator VolumetricFog(VolumetricFogInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         VolumetricFog ret = new VolumetricFog();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(VolumetricFogInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
