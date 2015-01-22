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
   public class PrecipitationDataInstance : GameBaseDataInstance
   {
      public PrecipitationDataInstance(string _name = "", string _className = "PrecipitationData", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public String dropShader
      {
         set { Fields["dropShader"] = value.ToString(); }
      }

      public int dropsPerSide
      {
         set { Fields["dropsPerSide"] = value.ToString(); }
      }

      public String dropTexture
      {
         set { Fields["dropTexture"] = value.ToString(); }
      }

      public SFXTrack soundProfile
      {
         set { Fields["soundProfile"] = value.ToString(); }
      }

      public int splashesPerSide
      {
         set { Fields["splashesPerSide"] = value.ToString(); }
      }

      public String splashShader
      {
         set { Fields["splashShader"] = value.ToString(); }
      }

      public String splashTexture
      {
         set { Fields["splashTexture"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator PrecipitationData(PrecipitationDataInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         PrecipitationData ret = new PrecipitationData();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(PrecipitationDataInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
