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
   public class GFXStateBlockDataInstance : SimObjectInstance
   {
      public GFXStateBlockDataInstance(string _name = "", string _className = "GFXStateBlockData", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool alphaDefined
      {
         set { Fields["alphaDefined"] = value.ToString(); }
      }

      public bool alphaTestEnable
      {
         set { Fields["alphaTestEnable"] = value.ToString(); }
      }

      public TypeGFXCmpFunc alphaTestFunc
      {
         set { Fields["alphaTestFunc"] = value.ToString(); }
      }

      public int alphaTestRef
      {
         set { Fields["alphaTestRef"] = value.ToString(); }
      }

      public bool blendDefined
      {
         set { Fields["blendDefined"] = value.ToString(); }
      }

      public TypeGFXBlend blendDest
      {
         set { Fields["blendDest"] = value.ToString(); }
      }

      public bool blendEnable
      {
         set { Fields["blendEnable"] = value.ToString(); }
      }

      public TypeGFXBlendOp blendOp
      {
         set { Fields["blendOp"] = value.ToString(); }
      }

      public TypeGFXBlend blendSrc
      {
         set { Fields["blendSrc"] = value.ToString(); }
      }

      public bool colorWriteAlpha
      {
         set { Fields["colorWriteAlpha"] = value.ToString(); }
      }

      public bool colorWriteBlue
      {
         set { Fields["colorWriteBlue"] = value.ToString(); }
      }

      public bool colorWriteDefined
      {
         set { Fields["colorWriteDefined"] = value.ToString(); }
      }

      public bool colorWriteGreen
      {
         set { Fields["colorWriteGreen"] = value.ToString(); }
      }

      public bool colorWriteRed
      {
         set { Fields["colorWriteRed"] = value.ToString(); }
      }

      public bool cullDefined
      {
         set { Fields["cullDefined"] = value.ToString(); }
      }

      public TypeGFXCullMode cullMode
      {
         set { Fields["cullMode"] = value.ToString(); }
      }

      public bool ffLighting
      {
         set { Fields["ffLighting"] = value.ToString(); }
      }

      public bool samplersDefined
      {
         set { Fields["samplersDefined"] = value.ToString(); }
      }

      private FieldWrapper<GFXSamplerStateData> _samplerStates = new FieldWrapper<GFXSamplerStateData>();
      public FieldWrapper<GFXSamplerStateData> samplerStates
      {
         get { _samplerStates.Set(ref mFieldsDictionary, "samplerStates"); return _samplerStates; }
         set { _samplerStates.Set(ref mFieldsDictionary, "samplerStates"); }
      }

      public bool separateAlphaBlendDefined
      {
         set { Fields["separateAlphaBlendDefined"] = value.ToString(); }
      }

      public TypeGFXBlend separateAlphaBlendDest
      {
         set { Fields["separateAlphaBlendDest"] = value.ToString(); }
      }

      public bool separateAlphaBlendEnable
      {
         set { Fields["separateAlphaBlendEnable"] = value.ToString(); }
      }

      public TypeGFXBlendOp separateAlphaBlendOp
      {
         set { Fields["separateAlphaBlendOp"] = value.ToString(); }
      }

      public TypeGFXBlend separateAlphaBlendSrc
      {
         set { Fields["separateAlphaBlendSrc"] = value.ToString(); }
      }

      public bool stencilDefined
      {
         set { Fields["stencilDefined"] = value.ToString(); }
      }

      public bool stencilEnable
      {
         set { Fields["stencilEnable"] = value.ToString(); }
      }

      public TypeGFXStencilOp stencilFailOp
      {
         set { Fields["stencilFailOp"] = value.ToString(); }
      }

      public TypeGFXCmpFunc stencilFunc
      {
         set { Fields["stencilFunc"] = value.ToString(); }
      }

      public int stencilMask
      {
         set { Fields["stencilMask"] = value.ToString(); }
      }

      public TypeGFXStencilOp stencilPassOp
      {
         set { Fields["stencilPassOp"] = value.ToString(); }
      }

      public int stencilRef
      {
         set { Fields["stencilRef"] = value.ToString(); }
      }

      public int stencilWriteMask
      {
         set { Fields["stencilWriteMask"] = value.ToString(); }
      }

      public TypeGFXStencilOp stencilZFailOp
      {
         set { Fields["stencilZFailOp"] = value.ToString(); }
      }

      public ColorI textureFactor
      {
         set { Fields["textureFactor"] = value.ToString(); }
      }

      public bool vertexColorEnable
      {
         set { Fields["vertexColorEnable"] = value.ToString(); }
      }

      public float zBias
      {
         set { Fields["zBias"] = value.ToString(); }
      }

      public bool zDefined
      {
         set { Fields["zDefined"] = value.ToString(); }
      }

      public bool zEnable
      {
         set { Fields["zEnable"] = value.ToString(); }
      }

      public TypeGFXCmpFunc zFunc
      {
         set { Fields["zFunc"] = value.ToString(); }
      }

      public float zSlopeBias
      {
         set { Fields["zSlopeBias"] = value.ToString(); }
      }

      public bool zWriteEnable
      {
         set { Fields["zWriteEnable"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GFXStateBlockData(GFXStateBlockDataInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GFXStateBlockData ret = new GFXStateBlockData();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GFXStateBlockDataInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
