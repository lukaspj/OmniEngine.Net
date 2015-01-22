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
   public class ScatterSkyInstance : SceneObjectInstance
   {
      public ScatterSkyInstance(string _name = "", string _className = "ScatterSky", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public ColorF ambientScale
      {
         set { Fields["ambientScale"] = value.ToString(); }
      }

      public float azimuth
      {
         set { Fields["azimuth"] = value.ToString(); }
      }

      public float brightness
      {
         set { Fields["brightness"] = value.ToString(); }
      }

      public bool castShadows
      {
         set { Fields["castShadows"] = value.ToString(); }
      }

      public ColorF colorize
      {
         set { Fields["colorize"] = value.ToString(); }
      }

      public float colorizeAmount
      {
         set { Fields["colorizeAmount"] = value.ToString(); }
      }

      public float elevation
      {
         set { Fields["elevation"] = value.ToString(); }
      }

      public float exposure
      {
         set { Fields["exposure"] = value.ToString(); }
      }

      public float flareScale
      {
         set { Fields["flareScale"] = value.ToString(); }
      }

      public LightFlareData flareType
      {
         set { Fields["flareType"] = value.ToString(); }
      }

      public ColorF fogScale
      {
         set { Fields["fogScale"] = value.ToString(); }
      }

      public float moonAzimuth
      {
         set { Fields["moonAzimuth"] = value.ToString(); }
      }

      public float moonElevation
      {
         set { Fields["moonElevation"] = value.ToString(); }
      }

      public bool moonEnabled
      {
         set { Fields["moonEnabled"] = value.ToString(); }
      }

      public ColorF moonLightColor
      {
         set { Fields["moonLightColor"] = value.ToString(); }
      }

      public TypeMaterialName moonMat
      {
         set { Fields["moonMat"] = value.ToString(); }
      }

      public float moonScale
      {
         set { Fields["moonScale"] = value.ToString(); }
      }

      public ColorF nightColor
      {
         set { Fields["nightColor"] = value.ToString(); }
      }

      public TypeCubemapName nightCubemap
      {
         set { Fields["nightCubemap"] = value.ToString(); }
      }

      public ColorF nightFogColor
      {
         set { Fields["nightFogColor"] = value.ToString(); }
      }

      public float rayleighScattering
      {
         set { Fields["rayleighScattering"] = value.ToString(); }
      }

      public float skyBrightness
      {
         set { Fields["skyBrightness"] = value.ToString(); }
      }

      public ColorF sunScale
      {
         set { Fields["sunScale"] = value.ToString(); }
      }

      public float sunSize
      {
         set { Fields["sunSize"] = value.ToString(); }
      }

      public bool useNightCubemap
      {
         set { Fields["useNightCubemap"] = value.ToString(); }
      }

      public float zoffset
      {
         set { Fields["zoffset"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator ScatterSky(ScatterSkyInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         ScatterSky ret = new ScatterSky();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(ScatterSkyInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
