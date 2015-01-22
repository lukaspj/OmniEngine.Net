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
   public class PostEffectInstance : SimGroupInstance
   {
      public PostEffectInstance(string _name = "", string _className = "PostEffect", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool allowReflectPass
      {
         set { Fields["allowReflectPass"] = value.ToString(); }
      }

      public bool isEnabled
      {
         set { Fields["isEnabled"] = value.ToString(); }
      }

      public bool oneFrameOnly
      {
         set { Fields["oneFrameOnly"] = value.ToString(); }
      }

      public bool onThisFrame
      {
         set { Fields["onThisFrame"] = value.ToString(); }
      }

      public String renderBin
      {
         set { Fields["renderBin"] = value.ToString(); }
      }

      public float renderPriority
      {
         set { Fields["renderPriority"] = value.ToString(); }
      }

      public TypePFXRenderTime renderTime
      {
         set { Fields["renderTime"] = value.ToString(); }
      }

      public String shader
      {
         set { Fields["shader"] = value.ToString(); }
      }

      public bool skip
      {
         set { Fields["skip"] = value.ToString(); }
      }

      public GFXStateBlockData stateBlock
      {
         set { Fields["stateBlock"] = value.ToString(); }
      }

      public String target
      {
         set { Fields["target"] = value.ToString(); }
      }

      public TypePFXTargetClear targetClear
      {
         set { Fields["targetClear"] = value.ToString(); }
      }

      public ColorF targetClearColor
      {
         set { Fields["targetClearColor"] = value.ToString(); }
      }

      public String targetDepthStencil
      {
         set { Fields["targetDepthStencil"] = value.ToString(); }
      }

      public TypeGFXFormat targetFormat
      {
         set { Fields["targetFormat"] = value.ToString(); }
      }

      public Point2F targetScale
      {
         set { Fields["targetScale"] = value.ToString(); }
      }

      public Point2I targetSize
      {
         set { Fields["targetSize"] = value.ToString(); }
      }

      public TypePFXTargetViewport targetViewport
      {
         set { Fields["targetViewport"] = value.ToString(); }
      }

      private FieldWrapper<TypeImageFilename> _texture = new FieldWrapper<TypeImageFilename>();
      public FieldWrapper<TypeImageFilename> texture
      {
         get { _texture.Set(ref mFieldsDictionary, "texture"); return _texture; }
         set { _texture.Set(ref mFieldsDictionary, "texture"); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator PostEffect(PostEffectInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         PostEffect ret = new PostEffect();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(PostEffectInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
