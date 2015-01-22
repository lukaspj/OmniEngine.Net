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
   public class TheoraTextureObjectInstance : SimObjectInstance
   {
      public TheoraTextureObjectInstance(string _name = "", string _className = "TheoraTextureObject", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool loop
      {
         set { Fields["loop"] = value.ToString(); }
      }

      public TypeSFXDescriptionName sfxDescription
      {
         set { Fields["sfxDescription"] = value.ToString(); }
      }

      public String texTargetName
      {
         set { Fields["texTargetName"] = value.ToString(); }
      }

      public String theoraFile
      {
         set { Fields["theoraFile"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator TheoraTextureObject(TheoraTextureObjectInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         TheoraTextureObject ret = new TheoraTextureObject();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(TheoraTextureObjectInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
