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
   public class LightAnimDataInstance : SimDataBlockInstance
   {
      public LightAnimDataInstance(string _name = "", string _className = "LightAnimData", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float brightnessA
      {
         set { Fields["brightnessA"] = value.ToString(); }
      }

      public String brightnessKeys
      {
         set { Fields["brightnessKeys"] = value.ToString(); }
      }

      public float brightnessPeriod
      {
         set { Fields["brightnessPeriod"] = value.ToString(); }
      }

      public bool brightnessSmooth
      {
         set { Fields["brightnessSmooth"] = value.ToString(); }
      }

      public float brightnessZ
      {
         set { Fields["brightnessZ"] = value.ToString(); }
      }

      private FieldWrapper<float> _colorA = new FieldWrapper<float>();
      public FieldWrapper<float> colorA
      {
         get { _colorA.Set(ref mFieldsDictionary, "colorA"); return _colorA; }
         set { _colorA.Set(ref mFieldsDictionary, "colorA"); }
      }

      private FieldWrapper<String> _colorKeys = new FieldWrapper<String>();
      public FieldWrapper<String> colorKeys
      {
         get { _colorKeys.Set(ref mFieldsDictionary, "colorKeys"); return _colorKeys; }
         set { _colorKeys.Set(ref mFieldsDictionary, "colorKeys"); }
      }

      private FieldWrapper<float> _colorPeriod = new FieldWrapper<float>();
      public FieldWrapper<float> colorPeriod
      {
         get { _colorPeriod.Set(ref mFieldsDictionary, "colorPeriod"); return _colorPeriod; }
         set { _colorPeriod.Set(ref mFieldsDictionary, "colorPeriod"); }
      }

      private FieldWrapper<bool> _colorSmooth = new FieldWrapper<bool>();
      public FieldWrapper<bool> colorSmooth
      {
         get { _colorSmooth.Set(ref mFieldsDictionary, "colorSmooth"); return _colorSmooth; }
         set { _colorSmooth.Set(ref mFieldsDictionary, "colorSmooth"); }
      }

      private FieldWrapper<float> _colorZ = new FieldWrapper<float>();
      public FieldWrapper<float> colorZ
      {
         get { _colorZ.Set(ref mFieldsDictionary, "colorZ"); return _colorZ; }
         set { _colorZ.Set(ref mFieldsDictionary, "colorZ"); }
      }

      private FieldWrapper<float> _offsetA = new FieldWrapper<float>();
      public FieldWrapper<float> offsetA
      {
         get { _offsetA.Set(ref mFieldsDictionary, "offsetA"); return _offsetA; }
         set { _offsetA.Set(ref mFieldsDictionary, "offsetA"); }
      }

      private FieldWrapper<String> _offsetKeys = new FieldWrapper<String>();
      public FieldWrapper<String> offsetKeys
      {
         get { _offsetKeys.Set(ref mFieldsDictionary, "offsetKeys"); return _offsetKeys; }
         set { _offsetKeys.Set(ref mFieldsDictionary, "offsetKeys"); }
      }

      private FieldWrapper<float> _offsetPeriod = new FieldWrapper<float>();
      public FieldWrapper<float> offsetPeriod
      {
         get { _offsetPeriod.Set(ref mFieldsDictionary, "offsetPeriod"); return _offsetPeriod; }
         set { _offsetPeriod.Set(ref mFieldsDictionary, "offsetPeriod"); }
      }

      private FieldWrapper<bool> _offsetSmooth = new FieldWrapper<bool>();
      public FieldWrapper<bool> offsetSmooth
      {
         get { _offsetSmooth.Set(ref mFieldsDictionary, "offsetSmooth"); return _offsetSmooth; }
         set { _offsetSmooth.Set(ref mFieldsDictionary, "offsetSmooth"); }
      }

      private FieldWrapper<float> _offsetZ = new FieldWrapper<float>();
      public FieldWrapper<float> offsetZ
      {
         get { _offsetZ.Set(ref mFieldsDictionary, "offsetZ"); return _offsetZ; }
         set { _offsetZ.Set(ref mFieldsDictionary, "offsetZ"); }
      }

      private FieldWrapper<float> _rotA = new FieldWrapper<float>();
      public FieldWrapper<float> rotA
      {
         get { _rotA.Set(ref mFieldsDictionary, "rotA"); return _rotA; }
         set { _rotA.Set(ref mFieldsDictionary, "rotA"); }
      }

      private FieldWrapper<String> _rotKeys = new FieldWrapper<String>();
      public FieldWrapper<String> rotKeys
      {
         get { _rotKeys.Set(ref mFieldsDictionary, "rotKeys"); return _rotKeys; }
         set { _rotKeys.Set(ref mFieldsDictionary, "rotKeys"); }
      }

      private FieldWrapper<float> _rotPeriod = new FieldWrapper<float>();
      public FieldWrapper<float> rotPeriod
      {
         get { _rotPeriod.Set(ref mFieldsDictionary, "rotPeriod"); return _rotPeriod; }
         set { _rotPeriod.Set(ref mFieldsDictionary, "rotPeriod"); }
      }

      private FieldWrapper<bool> _rotSmooth = new FieldWrapper<bool>();
      public FieldWrapper<bool> rotSmooth
      {
         get { _rotSmooth.Set(ref mFieldsDictionary, "rotSmooth"); return _rotSmooth; }
         set { _rotSmooth.Set(ref mFieldsDictionary, "rotSmooth"); }
      }

      private FieldWrapper<float> _rotZ = new FieldWrapper<float>();
      public FieldWrapper<float> rotZ
      {
         get { _rotZ.Set(ref mFieldsDictionary, "rotZ"); return _rotZ; }
         set { _rotZ.Set(ref mFieldsDictionary, "rotZ"); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator LightAnimData(LightAnimDataInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         LightAnimData ret = new LightAnimData();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(LightAnimDataInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
