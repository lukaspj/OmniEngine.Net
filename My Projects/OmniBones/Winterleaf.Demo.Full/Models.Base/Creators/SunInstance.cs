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
   public class SunInstance : SceneObjectInstance
   {
      public SunInstance(string _name = "", string _className = "Sun", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public ColorF ambient
      {
         set { Fields["ambient"] = value.ToString(); }
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

      public ColorF color
      {
         set { Fields["color"] = value.ToString(); }
      }

      public bool coronaEnabled
      {
         set { Fields["coronaEnabled"] = value.ToString(); }
      }

      public TypeMaterialName coronaMaterial
      {
         set { Fields["coronaMaterial"] = value.ToString(); }
      }

      public float coronaScale
      {
         set { Fields["coronaScale"] = value.ToString(); }
      }

      public ColorF coronaTint
      {
         set { Fields["coronaTint"] = value.ToString(); }
      }

      public bool coronaUseLightColor
      {
         set { Fields["coronaUseLightColor"] = value.ToString(); }
      }

      public float elevation
      {
         set { Fields["elevation"] = value.ToString(); }
      }

      public float flareScale
      {
         set { Fields["flareScale"] = value.ToString(); }
      }

      public LightFlareData flareType
      {
         set { Fields["flareType"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator Sun(SunInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         Sun ret = new Sun();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(SunInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
