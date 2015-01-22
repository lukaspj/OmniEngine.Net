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
   public class PrecipitationInstance : GameBaseInstance
   {
      public PrecipitationInstance(string _name = "", string _className = "Precipitation", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool animateSplashes
      {
         set { Fields["animateSplashes"] = value.ToString(); }
      }

      public float boxHeight
      {
         set { Fields["boxHeight"] = value.ToString(); }
      }

      public float boxWidth
      {
         set { Fields["boxWidth"] = value.ToString(); }
      }

      public bool doCollision
      {
         set { Fields["doCollision"] = value.ToString(); }
      }

      public int dropAnimateMS
      {
         set { Fields["dropAnimateMS"] = value.ToString(); }
      }

      public float dropSize
      {
         set { Fields["dropSize"] = value.ToString(); }
      }

      public float fadeDist
      {
         set { Fields["fadeDist"] = value.ToString(); }
      }

      public float fadeDistEnd
      {
         set { Fields["fadeDistEnd"] = value.ToString(); }
      }

      public bool followCam
      {
         set { Fields["followCam"] = value.ToString(); }
      }

      public ColorF glowIntensity
      {
         set { Fields["glowIntensity"] = value.ToString(); }
      }

      public bool hitPlayers
      {
         set { Fields["hitPlayers"] = value.ToString(); }
      }

      public bool hitVehicles
      {
         set { Fields["hitVehicles"] = value.ToString(); }
      }

      public float maxMass
      {
         set { Fields["maxMass"] = value.ToString(); }
      }

      public float maxSpeed
      {
         set { Fields["maxSpeed"] = value.ToString(); }
      }

      public float maxTurbulence
      {
         set { Fields["maxTurbulence"] = value.ToString(); }
      }

      public float minMass
      {
         set { Fields["minMass"] = value.ToString(); }
      }

      public float minSpeed
      {
         set { Fields["minSpeed"] = value.ToString(); }
      }

      public int numDrops
      {
         set { Fields["numDrops"] = value.ToString(); }
      }

      public bool reflect
      {
         set { Fields["reflect"] = value.ToString(); }
      }

      public bool rotateWithCamVel
      {
         set { Fields["rotateWithCamVel"] = value.ToString(); }
      }

      public int splashMS
      {
         set { Fields["splashMS"] = value.ToString(); }
      }

      public float splashSize
      {
         set { Fields["splashSize"] = value.ToString(); }
      }

      public float turbulenceSpeed
      {
         set { Fields["turbulenceSpeed"] = value.ToString(); }
      }

      public bool useLighting
      {
         set { Fields["useLighting"] = value.ToString(); }
      }

      public bool useTrueBillboards
      {
         set { Fields["useTrueBillboards"] = value.ToString(); }
      }

      public bool useTurbulence
      {
         set { Fields["useTurbulence"] = value.ToString(); }
      }

      public bool useWind
      {
         set { Fields["useWind"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator Precipitation(PrecipitationInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         Precipitation ret = new Precipitation();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(PrecipitationInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
