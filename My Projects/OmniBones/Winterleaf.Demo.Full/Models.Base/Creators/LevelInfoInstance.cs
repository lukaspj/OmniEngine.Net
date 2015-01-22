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
   public class LevelInfoInstance : NetObjectInstance
   {
      public LevelInfoInstance(string _name = "", string _className = "LevelInfo", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool advancedLightmapSupport
      {
         set { Fields["advancedLightmapSupport"] = value.ToString(); }
      }

      public EaseF ambientLightBlendCurve
      {
         set { Fields["ambientLightBlendCurve"] = value.ToString(); }
      }

      public float ambientLightBlendPhase
      {
         set { Fields["ambientLightBlendPhase"] = value.ToString(); }
      }

      public ColorI canvasClearColor
      {
         set { Fields["canvasClearColor"] = value.ToString(); }
      }

      public float decalBias
      {
         set { Fields["decalBias"] = value.ToString(); }
      }

      public float fogAtmosphereHeight
      {
         set { Fields["fogAtmosphereHeight"] = value.ToString(); }
      }

      public ColorF fogColor
      {
         set { Fields["fogColor"] = value.ToString(); }
      }

      public float fogDensity
      {
         set { Fields["fogDensity"] = value.ToString(); }
      }

      public float fogDensityOffset
      {
         set { Fields["fogDensityOffset"] = value.ToString(); }
      }

      public Point4F frustumOffset
      {
         set { Fields["frustumOffset"] = value.ToString(); }
      }

      public float nearClip
      {
         set { Fields["nearClip"] = value.ToString(); }
      }

      public TypeSFXAmbienceName soundAmbience
      {
         set { Fields["soundAmbience"] = value.ToString(); }
      }

      public TypeSFXDistanceModel soundDistanceModel
      {
         set { Fields["soundDistanceModel"] = value.ToString(); }
      }

      public float visibleDistance
      {
         set { Fields["visibleDistance"] = value.ToString(); }
      }

      public float visibleDistance_Ghost
      {
         set { Fields["visibleDistance_Ghost"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator LevelInfo(LevelInfoInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         LevelInfo ret = new LevelInfo();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(LevelInfoInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
