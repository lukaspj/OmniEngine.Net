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
   public class LightFlareDataInstance : SimDataBlockInstance
   {
      public LightFlareDataInstance(string _name = "", string _className = "LightFlareData", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      private FieldWrapper<float> _elementDist = new FieldWrapper<float>();
      public FieldWrapper<float> elementDist
      {
         get { _elementDist.Set(ref mFieldsDictionary, "elementDist"); return _elementDist; }
         set { _elementDist.Set(ref mFieldsDictionary, "elementDist"); }
      }

      private FieldWrapper<RectF> _elementRect = new FieldWrapper<RectF>();
      public FieldWrapper<RectF> elementRect
      {
         get { _elementRect.Set(ref mFieldsDictionary, "elementRect"); return _elementRect; }
         set { _elementRect.Set(ref mFieldsDictionary, "elementRect"); }
      }

      private FieldWrapper<bool> _elementRotate = new FieldWrapper<bool>();
      public FieldWrapper<bool> elementRotate
      {
         get { _elementRotate.Set(ref mFieldsDictionary, "elementRotate"); return _elementRotate; }
         set { _elementRotate.Set(ref mFieldsDictionary, "elementRotate"); }
      }

      private FieldWrapper<float> _elementScale = new FieldWrapper<float>();
      public FieldWrapper<float> elementScale
      {
         get { _elementScale.Set(ref mFieldsDictionary, "elementScale"); return _elementScale; }
         set { _elementScale.Set(ref mFieldsDictionary, "elementScale"); }
      }

      private FieldWrapper<ColorF> _elementTint = new FieldWrapper<ColorF>();
      public FieldWrapper<ColorF> elementTint
      {
         get { _elementTint.Set(ref mFieldsDictionary, "elementTint"); return _elementTint; }
         set { _elementTint.Set(ref mFieldsDictionary, "elementTint"); }
      }

      private FieldWrapper<bool> _elementUseLightColor = new FieldWrapper<bool>();
      public FieldWrapper<bool> elementUseLightColor
      {
         get { _elementUseLightColor.Set(ref mFieldsDictionary, "elementUseLightColor"); return _elementUseLightColor; }
         set { _elementUseLightColor.Set(ref mFieldsDictionary, "elementUseLightColor"); }
      }

      public bool flareEnabled
      {
         set { Fields["flareEnabled"] = value.ToString(); }
      }

      public TypeImageFilename flareTexture
      {
         set { Fields["flareTexture"] = value.ToString(); }
      }

      public float occlusionRadius
      {
         set { Fields["occlusionRadius"] = value.ToString(); }
      }

      public float overallScale
      {
         set { Fields["overallScale"] = value.ToString(); }
      }

      public bool renderReflectPass
      {
         set { Fields["renderReflectPass"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator LightFlareData(LightFlareDataInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         LightFlareData ret = new LightFlareData();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(LightFlareDataInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
