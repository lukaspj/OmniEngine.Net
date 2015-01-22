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
   public class CloudLayerInstance : SceneObjectInstance
   {
      public CloudLayerInstance(string _name = "", string _className = "CloudLayer", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public ColorF baseColor
      {
         set { Fields["baseColor"] = value.ToString(); }
      }

      public float coverage
      {
         set { Fields["coverage"] = value.ToString(); }
      }

      public float exposure
      {
         set { Fields["exposure"] = value.ToString(); }
      }

      public float height
      {
         set { Fields["height"] = value.ToString(); }
      }

      private FieldWrapper<Point2F> _texDirection = new FieldWrapper<Point2F>();
      public FieldWrapper<Point2F> texDirection
      {
         get { _texDirection.Set(ref mFieldsDictionary, "texDirection"); return _texDirection; }
         set { _texDirection.Set(ref mFieldsDictionary, "texDirection"); }
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

      public TypeImageFilename texture
      {
         set { Fields["texture"] = value.ToString(); }
      }

      public float windSpeed
      {
         set { Fields["windSpeed"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator CloudLayer(CloudLayerInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         CloudLayer ret = new CloudLayer();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(CloudLayerInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
