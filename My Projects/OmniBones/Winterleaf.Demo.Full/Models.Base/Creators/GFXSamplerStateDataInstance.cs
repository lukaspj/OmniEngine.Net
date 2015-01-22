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
   public class GFXSamplerStateDataInstance : SimObjectInstance
   {
      public GFXSamplerStateDataInstance(string _name = "", string _className = "GFXSamplerStateData", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public TypeGFXTextureAddressMode addressModeU
      {
         set { Fields["addressModeU"] = value.ToString(); }
      }

      public TypeGFXTextureAddressMode addressModeV
      {
         set { Fields["addressModeV"] = value.ToString(); }
      }

      public TypeGFXTextureAddressMode addressModeW
      {
         set { Fields["addressModeW"] = value.ToString(); }
      }

      public TypeGFXTextureArgument alphaArg1
      {
         set { Fields["alphaArg1"] = value.ToString(); }
      }

      public TypeGFXTextureArgument alphaArg2
      {
         set { Fields["alphaArg2"] = value.ToString(); }
      }

      public TypeGFXTextureArgument alphaArg3
      {
         set { Fields["alphaArg3"] = value.ToString(); }
      }

      public TypeGFXTextureOp alphaOp
      {
         set { Fields["alphaOp"] = value.ToString(); }
      }

      public TypeGFXTextureArgument colorArg1
      {
         set { Fields["colorArg1"] = value.ToString(); }
      }

      public TypeGFXTextureArgument colorArg2
      {
         set { Fields["colorArg2"] = value.ToString(); }
      }

      public TypeGFXTextureArgument colorArg3
      {
         set { Fields["colorArg3"] = value.ToString(); }
      }

      public TypeGFXTextureFilterType magFilter
      {
         set { Fields["magFilter"] = value.ToString(); }
      }

      public int maxAnisotropy
      {
         set { Fields["maxAnisotropy"] = value.ToString(); }
      }

      public TypeGFXTextureFilterType minFilter
      {
         set { Fields["minFilter"] = value.ToString(); }
      }

      public TypeGFXTextureFilterType mipFilter
      {
         set { Fields["mipFilter"] = value.ToString(); }
      }

      public float mipLODBias
      {
         set { Fields["mipLODBias"] = value.ToString(); }
      }

      public TypeGFXTextureArgument resultArg
      {
         set { Fields["resultArg"] = value.ToString(); }
      }

      public TypeGFXTextureOp textureColorOp
      {
         set { Fields["textureColorOp"] = value.ToString(); }
      }

      public TypeGFXTextureTransformFlags textureTransform
      {
         set { Fields["textureTransform"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GFXSamplerStateData(GFXSamplerStateDataInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GFXSamplerStateData ret = new GFXSamplerStateData();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GFXSamplerStateDataInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
