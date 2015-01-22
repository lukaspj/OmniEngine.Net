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
   public class BasicCloudsInstance : SceneObjectInstance
   {
      public BasicCloudsInstance(string _name = "", string _className = "BasicClouds", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      private FieldWrapper<float> _height = new FieldWrapper<float>();
      public FieldWrapper<float> height
      {
         get { _height.Set(ref mFieldsDictionary, "height"); return _height; }
         set { _height.Set(ref mFieldsDictionary, "height"); }
      }

      private FieldWrapper<bool> _layerEnabled = new FieldWrapper<bool>();
      public FieldWrapper<bool> layerEnabled
      {
         get { _layerEnabled.Set(ref mFieldsDictionary, "layerEnabled"); return _layerEnabled; }
         set { _layerEnabled.Set(ref mFieldsDictionary, "layerEnabled"); }
      }

      private FieldWrapper<Point2F> _texDirection = new FieldWrapper<Point2F>();
      public FieldWrapper<Point2F> texDirection
      {
         get { _texDirection.Set(ref mFieldsDictionary, "texDirection"); return _texDirection; }
         set { _texDirection.Set(ref mFieldsDictionary, "texDirection"); }
      }

      private FieldWrapper<Point2F> _texOffset = new FieldWrapper<Point2F>();
      public FieldWrapper<Point2F> texOffset
      {
         get { _texOffset.Set(ref mFieldsDictionary, "texOffset"); return _texOffset; }
         set { _texOffset.Set(ref mFieldsDictionary, "texOffset"); }
      }

      private FieldWrapper<float> _texScale = new FieldWrapper<float>();
      public FieldWrapper<float> texScale
      {
         get { _texScale.Set(ref mFieldsDictionary, "texScale"); return _texScale; }
         set { _texScale.Set(ref mFieldsDictionary, "texScale"); }
      }

      private FieldWrapper<float> _texSpeed = new FieldWrapper<float>();
      public FieldWrapper<float> texSpeed
      {
         get { _texSpeed.Set(ref mFieldsDictionary, "texSpeed"); return _texSpeed; }
         set { _texSpeed.Set(ref mFieldsDictionary, "texSpeed"); }
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
      public static implicit operator BasicClouds(BasicCloudsInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         BasicClouds ret = new BasicClouds();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(BasicCloudsInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
